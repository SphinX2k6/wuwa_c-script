using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F2 RID: 2546
	[NetMessage(EMessageId.MonsterLevelNotify)]
	public sealed class MonsterLevelNotify : IMessage<MonsterLevelNotify>, IMessage, IEquatable<MonsterLevelNotify>, IDeepCloneable<MonsterLevelNotify>, IBufferMessage
	{
		// Token: 0x0600DF34 RID: 57140 RVA: 0x0020BC95 File Offset: 0x00209E95
		[NullableContext(1)]
		public static MonsterLevelNotify Create()
		{
			return new MonsterLevelNotify();
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0600DF35 RID: 57141 RVA: 0x0020BC9C File Offset: 0x00209E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonsterLevelNotify> Parser
		{
			get
			{
				return MonsterLevelNotify._parser;
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0600DF36 RID: 57142 RVA: 0x0020BCA3 File Offset: 0x00209EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0600DF37 RID: 57143 RVA: 0x0020BCA6 File Offset: 0x00209EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600DF38 RID: 57144 RVA: 0x0020BCAD File Offset: 0x00209EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelNotify()
		{
		}

		// Token: 0x0600DF39 RID: 57145 RVA: 0x0020BCB5 File Offset: 0x00209EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelNotify(MonsterLevelNotify other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF3A RID: 57146 RVA: 0x0020BCE6 File Offset: 0x00209EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterLevelNotify Clone()
		{
			return new MonsterLevelNotify(this);
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0600DF3B RID: 57147 RVA: 0x0020BCEE File Offset: 0x00209EEE
		// (set) Token: 0x0600DF3C RID: 57148 RVA: 0x0020BCF6 File Offset: 0x00209EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0600DF3D RID: 57149 RVA: 0x0020BCFF File Offset: 0x00209EFF
		// (set) Token: 0x0600DF3E RID: 57150 RVA: 0x0020BD07 File Offset: 0x00209F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600DF3F RID: 57151 RVA: 0x0020BD10 File Offset: 0x00209F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterLevelNotify);
		}

		// Token: 0x0600DF40 RID: 57152 RVA: 0x0020BD1E File Offset: 0x00209F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterLevelNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF41 RID: 57153 RVA: 0x0020BD5C File Offset: 0x00209F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF42 RID: 57154 RVA: 0x0020BDB4 File Offset: 0x00209FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF43 RID: 57155 RVA: 0x0020BDC1 File Offset: 0x00209FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF44 RID: 57156 RVA: 0x0020BDCC File Offset: 0x00209FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF45 RID: 57157 RVA: 0x0020BE28 File Offset: 0x0020A028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF46 RID: 57158 RVA: 0x0020BE80 File Offset: 0x0020A080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF47 RID: 57159 RVA: 0x0020BED0 File Offset: 0x0020A0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF48 RID: 57160 RVA: 0x0020BEDC File Offset: 0x0020A0DC
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
				if (num != 64U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005C63 RID: 23651
		private static readonly MessageParser<MonsterLevelNotify> _parser = new MessageParser<MonsterLevelNotify>(() => new MonsterLevelNotify());

		// Token: 0x04005C64 RID: 23652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C65 RID: 23653
		public const int IdFieldNumber = 8;

		// Token: 0x04005C66 RID: 23654
		private long id_;

		// Token: 0x04005C67 RID: 23655
		public const int LevelFieldNumber = 15;

		// Token: 0x04005C68 RID: 23656
		private int level_;
	}
}
