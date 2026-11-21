using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001AB RID: 427
	public sealed class BlackCoastThemeStageInfo : IMessage<BlackCoastThemeStageInfo>, IMessage, IEquatable<BlackCoastThemeStageInfo>, IDeepCloneable<BlackCoastThemeStageInfo>, IBufferMessage
	{
		// Token: 0x06003235 RID: 12853 RVA: 0x0007FFB2 File Offset: 0x0007E1B2
		[NullableContext(1)]
		public static BlackCoastThemeStageInfo Create()
		{
			return new BlackCoastThemeStageInfo();
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x0007FFB9 File Offset: 0x0007E1B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BlackCoastThemeStageInfo> Parser
		{
			get
			{
				return BlackCoastThemeStageInfo._parser;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x0007FFC0 File Offset: 0x0007E1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x0007FFC3 File Offset: 0x0007E1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackCoastThemeStageInfo.Descriptor;
			}
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x0007FFCA File Offset: 0x0007E1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageInfo()
		{
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x0007FFDD File Offset: 0x0007E1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageInfo(BlackCoastThemeStageInfo other) : this()
		{
			this.id_ = other.id_;
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x00080013 File Offset: 0x0007E213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackCoastThemeStageInfo Clone()
		{
			return new BlackCoastThemeStageInfo(this);
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x0008001B File Offset: 0x0007E21B
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x00080023 File Offset: 0x0007E223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x0008002C File Offset: 0x0007E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x00080034 File Offset: 0x0007E234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackCoastThemeStageInfo);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x00080044 File Offset: 0x0007E244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackCoastThemeStageInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x00080094 File Offset: 0x0007E294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000800E1 File Offset: 0x0007E2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000800EE File Offset: 0x0007E2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x000800F8 File Offset: 0x0007E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.tasks_.WriteTo(ref output, BlackCoastThemeStageInfo._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x00080148 File Offset: 0x0007E348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.tasks_.CalculateSize(BlackCoastThemeStageInfo._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0008019C File Offset: 0x0007E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackCoastThemeStageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.tasks_.Add(other.tasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x000801E9 File Offset: 0x0007E3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000801F4 File Offset: 0x0007E3F4
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tasks_.AddEntriesFrom(ref input, BlackCoastThemeStageInfo._repeated_tasks_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029BF RID: 10687
		private static readonly MessageParser<BlackCoastThemeStageInfo> _parser = new MessageParser<BlackCoastThemeStageInfo>(() => new BlackCoastThemeStageInfo());

		// Token: 0x040029C0 RID: 10688
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029C1 RID: 10689
		public const int IdFieldNumber = 1;

		// Token: 0x040029C2 RID: 10690
		private int id_;

		// Token: 0x040029C3 RID: 10691
		public const int TasksFieldNumber = 2;

		// Token: 0x040029C4 RID: 10692
		private static readonly FieldCodec<ActivityTask> _repeated_tasks_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x040029C5 RID: 10693
		private readonly RepeatedField<ActivityTask> tasks_ = new RepeatedField<ActivityTask>();
	}
}
