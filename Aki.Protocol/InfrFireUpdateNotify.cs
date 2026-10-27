using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DC RID: 2012
	[NetMessage(EMessageId.InfrFireUpdateNotify)]
	public sealed class InfrFireUpdateNotify : IMessage<InfrFireUpdateNotify>, IMessage, IEquatable<InfrFireUpdateNotify>, IDeepCloneable<InfrFireUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B4B0 RID: 46256 RVA: 0x001AFE90 File Offset: 0x001AE090
		[NullableContext(1)]
		public static InfrFireUpdateNotify Create()
		{
			return new InfrFireUpdateNotify();
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x0600B4B1 RID: 46257 RVA: 0x001AFE97 File Offset: 0x001AE097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x0600B4B2 RID: 46258 RVA: 0x001AFE9A File Offset: 0x001AE09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B4B3 RID: 46259 RVA: 0x001AFEA1 File Offset: 0x001AE0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireUpdateNotify()
		{
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x001AFEA9 File Offset: 0x001AE0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireUpdateNotify(InfrFireUpdateNotify other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B4B5 RID: 46261 RVA: 0x001AFEDE File Offset: 0x001AE0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireUpdateNotify Clone()
		{
			return new InfrFireUpdateNotify(this);
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x0600B4B6 RID: 46262 RVA: 0x001AFEE6 File Offset: 0x001AE0E6
		// (set) Token: 0x0600B4B7 RID: 46263 RVA: 0x001AFEEE File Offset: 0x001AE0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFirePb FireInfo
		{
			get
			{
				return this.fireInfo_;
			}
			set
			{
				this.fireInfo_ = value;
			}
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x001AFEF7 File Offset: 0x001AE0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireUpdateNotify);
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x001AFF05 File Offset: 0x001AE105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x001AFF38 File Offset: 0x001AE138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fireInfo_ != null)
			{
				num ^= this.FireInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x001AFF74 File Offset: 0x001AE174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B4BC RID: 46268 RVA: 0x001AFF81 File Offset: 0x001AE181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x001AFF8A File Offset: 0x001AE18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.FireInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x001AFFBC File Offset: 0x001AE1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fireInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FireInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x001AFFFC File Offset: 0x001AE1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrFireUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fireInfo_ != null)
			{
				if (this.fireInfo_ == null)
				{
					this.FireInfo = new InfrFirePb();
				}
				this.FireInfo.MergeFrom(other.FireInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x001B0050 File Offset: 0x001AE250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x001B005C File Offset: 0x001AE25C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.fireInfo_ == null)
					{
						this.FireInfo = new InfrFirePb();
					}
					input.ReadMessage(this.FireInfo);
				}
			}
		}

		// Token: 0x0400505B RID: 20571
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400505C RID: 20572
		public const int FireInfoFieldNumber = 6;

		// Token: 0x0400505D RID: 20573
		private InfrFirePb fireInfo_;
	}
}
