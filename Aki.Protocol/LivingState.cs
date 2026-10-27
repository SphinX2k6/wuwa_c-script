using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000939 RID: 2361
	public sealed class LivingState : IMessage<LivingState>, IMessage, IEquatable<LivingState>, IDeepCloneable<LivingState>, IBufferMessage
	{
		// Token: 0x0600D014 RID: 53268 RVA: 0x001EA0C0 File Offset: 0x001E82C0
		[NullableContext(1)]
		public static LivingState Create()
		{
			return new LivingState();
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0600D015 RID: 53269 RVA: 0x001EA0C7 File Offset: 0x001E82C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LivingState> Parser
		{
			get
			{
				return LivingState._parser;
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0600D016 RID: 53270 RVA: 0x001EA0CE File Offset: 0x001E82CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0600D017 RID: 53271 RVA: 0x001EA0D1 File Offset: 0x001E82D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivingState.Descriptor;
			}
		}

		// Token: 0x0600D018 RID: 53272 RVA: 0x001EA0D8 File Offset: 0x001E82D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingState()
		{
		}

		// Token: 0x0600D019 RID: 53273 RVA: 0x001EA0E0 File Offset: 0x001E82E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingState(LivingState other) : this()
		{
			this.group_ = other.group_;
			this.livingStatus_ = other.livingStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D01A RID: 53274 RVA: 0x001EA111 File Offset: 0x001E8311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingState Clone()
		{
			return new LivingState(this);
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x0600D01B RID: 53275 RVA: 0x001EA119 File Offset: 0x001E8319
		// (set) Token: 0x0600D01C RID: 53276 RVA: 0x001EA121 File Offset: 0x001E8321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Group
		{
			get
			{
				return this.group_;
			}
			set
			{
				this.group_ = value;
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x0600D01D RID: 53277 RVA: 0x001EA12A File Offset: 0x001E832A
		// (set) Token: 0x0600D01E RID: 53278 RVA: 0x001EA132 File Offset: 0x001E8332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingStatus LivingStatus
		{
			get
			{
				return this.livingStatus_;
			}
			set
			{
				this.livingStatus_ = value;
			}
		}

		// Token: 0x0600D01F RID: 53279 RVA: 0x001EA13B File Offset: 0x001E833B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivingState);
		}

		// Token: 0x0600D020 RID: 53280 RVA: 0x001EA149 File Offset: 0x001E8349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivingState other)
		{
			return other != null && (other == this || (this.Group == other.Group && this.LivingStatus == other.LivingStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D021 RID: 53281 RVA: 0x001EA188 File Offset: 0x001E8388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Group != 0)
			{
				num ^= this.Group.GetHashCode();
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num ^= this.LivingStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D022 RID: 53282 RVA: 0x001EA1E6 File Offset: 0x001E83E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D023 RID: 53283 RVA: 0x001EA1F3 File Offset: 0x001E83F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D024 RID: 53284 RVA: 0x001EA1FC File Offset: 0x001E83FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Group != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Group);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.LivingStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D025 RID: 53285 RVA: 0x001EA254 File Offset: 0x001E8454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Group != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Group);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LivingStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D026 RID: 53286 RVA: 0x001EA2AC File Offset: 0x001E84AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivingState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Group != 0)
			{
				this.Group = other.Group;
			}
			if (other.LivingStatus != LivingStatus.Alive)
			{
				this.LivingStatus = other.LivingStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D027 RID: 53287 RVA: 0x001EA2FC File Offset: 0x001E84FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D028 RID: 53288 RVA: 0x001EA308 File Offset: 0x001E8508
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LivingStatus = (LivingStatus)input.ReadEnum();
					}
				}
				else
				{
					this.Group = input.ReadInt32();
				}
			}
		}

		// Token: 0x040057B4 RID: 22452
		private static readonly MessageParser<LivingState> _parser = new MessageParser<LivingState>(() => new LivingState());

		// Token: 0x040057B5 RID: 22453
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057B6 RID: 22454
		public const int GroupFieldNumber = 1;

		// Token: 0x040057B7 RID: 22455
		private int group_;

		// Token: 0x040057B8 RID: 22456
		public const int LivingStatusFieldNumber = 2;

		// Token: 0x040057B9 RID: 22457
		private LivingStatus livingStatus_;
	}
}
