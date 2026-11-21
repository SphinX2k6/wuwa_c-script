using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200170C RID: 5900
	[NetMessage(EMessageId.CheatInputRequest)]
	public sealed class CheatInputRequest : IMessage<CheatInputRequest>, IMessage, IEquatable<CheatInputRequest>, IDeepCloneable<CheatInputRequest>, IBufferMessage
	{
		// Token: 0x0601D9CE RID: 121294 RVA: 0x0045792B File Offset: 0x00455B2B
		[NullableContext(1)]
		public static CheatInputRequest Create()
		{
			return new CheatInputRequest();
		}

		// Token: 0x170064C7 RID: 25799
		// (get) Token: 0x0601D9CF RID: 121295 RVA: 0x00457932 File Offset: 0x00455B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064C8 RID: 25800
		// (get) Token: 0x0601D9D0 RID: 121296 RVA: 0x00457935 File Offset: 0x00455B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheatInputRequest.Descriptor;
			}
		}

		// Token: 0x0601D9D1 RID: 121297 RVA: 0x0045793C File Offset: 0x00455B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputRequest()
		{
		}

		// Token: 0x0601D9D2 RID: 121298 RVA: 0x00457950 File Offset: 0x00455B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputRequest(CheatInputRequest other) : this()
		{
			this.type_ = other.type_;
			this.aoeDestroyEnemyRange_ = other.aoeDestroyEnemyRange_;
			this.entityList_ = other.entityList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D9D3 RID: 121299 RVA: 0x0045799D File Offset: 0x00455B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputRequest Clone()
		{
			return new CheatInputRequest(this);
		}

		// Token: 0x170064C9 RID: 25801
		// (get) Token: 0x0601D9D4 RID: 121300 RVA: 0x004579A5 File Offset: 0x00455BA5
		// (set) Token: 0x0601D9D5 RID: 121301 RVA: 0x004579AD File Offset: 0x00455BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECheatInput Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170064CA RID: 25802
		// (get) Token: 0x0601D9D6 RID: 121302 RVA: 0x004579B6 File Offset: 0x00455BB6
		// (set) Token: 0x0601D9D7 RID: 121303 RVA: 0x004579BE File Offset: 0x00455BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AoeDestroyEnemyRange
		{
			get
			{
				return this.aoeDestroyEnemyRange_;
			}
			set
			{
				this.aoeDestroyEnemyRange_ = value;
			}
		}

		// Token: 0x170064CB RID: 25803
		// (get) Token: 0x0601D9D8 RID: 121304 RVA: 0x004579C7 File Offset: 0x00455BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityList
		{
			get
			{
				return this.entityList_;
			}
		}

		// Token: 0x0601D9D9 RID: 121305 RVA: 0x004579CF File Offset: 0x00455BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheatInputRequest);
		}

		// Token: 0x0601D9DA RID: 121306 RVA: 0x004579E0 File Offset: 0x00455BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheatInputRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.AoeDestroyEnemyRange == other.AoeDestroyEnemyRange && this.entityList_.Equals(other.entityList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D9DB RID: 121307 RVA: 0x00457A40 File Offset: 0x00455C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != ECheatInput.Default)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.AoeDestroyEnemyRange != 0)
			{
				num ^= this.AoeDestroyEnemyRange.GetHashCode();
			}
			num ^= this.entityList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D9DC RID: 121308 RVA: 0x00457AAC File Offset: 0x00455CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D9DD RID: 121309 RVA: 0x00457AB9 File Offset: 0x00455CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D9DE RID: 121310 RVA: 0x00457AC4 File Offset: 0x00455CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != ECheatInput.Default)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Type);
			}
			if (this.AoeDestroyEnemyRange != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AoeDestroyEnemyRange);
			}
			this.entityList_.WriteTo(ref output, CheatInputRequest._repeated_entityList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D9DF RID: 121311 RVA: 0x00457B30 File Offset: 0x00455D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != ECheatInput.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.AoeDestroyEnemyRange != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AoeDestroyEnemyRange);
			}
			num += this.entityList_.CalculateSize(CheatInputRequest._repeated_entityList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D9E0 RID: 121312 RVA: 0x00457B9C File Offset: 0x00455D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheatInputRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != ECheatInput.Default)
			{
				this.Type = other.Type;
			}
			if (other.AoeDestroyEnemyRange != 0)
			{
				this.AoeDestroyEnemyRange = other.AoeDestroyEnemyRange;
			}
			this.entityList_.Add(other.entityList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D9E1 RID: 121313 RVA: 0x00457BFD File Offset: 0x00455DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D9E2 RID: 121314 RVA: 0x00457C08 File Offset: 0x00455E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 104U)
				{
					if (num == 40U)
					{
						this.Type = (ECheatInput)input.ReadEnum();
						continue;
					}
					if (num == 104U)
					{
						this.AoeDestroyEnemyRange = input.ReadInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.entityList_.AddEntriesFrom(ref input, CheatInputRequest._repeated_entityList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C88C RID: 51340
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C88D RID: 51341
		public const int TypeFieldNumber = 5;

		// Token: 0x0400C88E RID: 51342
		private ECheatInput type_;

		// Token: 0x0400C88F RID: 51343
		public const int AoeDestroyEnemyRangeFieldNumber = 13;

		// Token: 0x0400C890 RID: 51344
		private int aoeDestroyEnemyRange_;

		// Token: 0x0400C891 RID: 51345
		public const int EntityListFieldNumber = 14;

		// Token: 0x0400C892 RID: 51346
		private static readonly FieldCodec<long> _repeated_entityList_codec = FieldCodec.ForInt64(114U);

		// Token: 0x0400C893 RID: 51347
		private readonly RepeatedField<long> entityList_ = new RepeatedField<long>();
	}
}
