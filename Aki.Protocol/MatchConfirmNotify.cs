using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A6 RID: 2470
	[NetMessage(EMessageId.MatchConfirmNotify)]
	public sealed class MatchConfirmNotify : IMessage<MatchConfirmNotify>, IMessage, IEquatable<MatchConfirmNotify>, IDeepCloneable<MatchConfirmNotify>, IBufferMessage
	{
		// Token: 0x0600D91F RID: 55583 RVA: 0x001FE911 File Offset: 0x001FCB11
		[NullableContext(1)]
		public static MatchConfirmNotify Create()
		{
			return new MatchConfirmNotify();
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x0600D920 RID: 55584 RVA: 0x001FE918 File Offset: 0x001FCB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x0600D921 RID: 55585 RVA: 0x001FE91B File Offset: 0x001FCB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchConfirmNotify.Descriptor;
			}
		}

		// Token: 0x0600D922 RID: 55586 RVA: 0x001FE922 File Offset: 0x001FCB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmNotify()
		{
		}

		// Token: 0x0600D923 RID: 55587 RVA: 0x001FE92A File Offset: 0x001FCB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmNotify(MatchConfirmNotify other) : this()
		{
			this.confirmId_ = other.confirmId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D924 RID: 55588 RVA: 0x001FE94F File Offset: 0x001FCB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmNotify Clone()
		{
			return new MatchConfirmNotify(this);
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x0600D925 RID: 55589 RVA: 0x001FE957 File Offset: 0x001FCB57
		// (set) Token: 0x0600D926 RID: 55590 RVA: 0x001FE95F File Offset: 0x001FCB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfirmId
		{
			get
			{
				return this.confirmId_;
			}
			set
			{
				this.confirmId_ = value;
			}
		}

		// Token: 0x0600D927 RID: 55591 RVA: 0x001FE968 File Offset: 0x001FCB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchConfirmNotify);
		}

		// Token: 0x0600D928 RID: 55592 RVA: 0x001FE976 File Offset: 0x001FCB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchConfirmNotify other)
		{
			return other != null && (other == this || (this.ConfirmId == other.ConfirmId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D929 RID: 55593 RVA: 0x001FE9A4 File Offset: 0x001FCBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfirmId != 0)
			{
				num ^= this.ConfirmId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D92A RID: 55594 RVA: 0x001FE9E3 File Offset: 0x001FCBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D92B RID: 55595 RVA: 0x001FE9F0 File Offset: 0x001FCBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D92C RID: 55596 RVA: 0x001FE9F9 File Offset: 0x001FCBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfirmId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ConfirmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D92D RID: 55597 RVA: 0x001FEA2C File Offset: 0x001FCC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfirmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfirmId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D92E RID: 55598 RVA: 0x001FEA6A File Offset: 0x001FCC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchConfirmNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfirmId != 0)
			{
				this.ConfirmId = other.ConfirmId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D92F RID: 55599 RVA: 0x001FEA9B File Offset: 0x001FCC9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D930 RID: 55600 RVA: 0x001FEAA4 File Offset: 0x001FCCA4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfirmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005AB2 RID: 23218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AB3 RID: 23219
		public const int ConfirmIdFieldNumber = 11;

		// Token: 0x04005AB4 RID: 23220
		private int confirmId_;
	}
}
