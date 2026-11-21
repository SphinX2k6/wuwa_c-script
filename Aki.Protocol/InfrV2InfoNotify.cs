using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E5 RID: 2021
	[NetMessage(EMessageId.InfrV2InfoNotify)]
	public sealed class InfrV2InfoNotify : IMessage<InfrV2InfoNotify>, IMessage, IEquatable<InfrV2InfoNotify>, IDeepCloneable<InfrV2InfoNotify>, IBufferMessage
	{
		// Token: 0x0600B58E RID: 46478 RVA: 0x001B1BE7 File Offset: 0x001AFDE7
		[NullableContext(1)]
		public static InfrV2InfoNotify Create()
		{
			return new InfrV2InfoNotify();
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x0600B58F RID: 46479 RVA: 0x001B1BEE File Offset: 0x001AFDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x001B1BF1 File Offset: 0x001AFDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2InfoNotify.Descriptor;
			}
		}

		// Token: 0x0600B591 RID: 46481 RVA: 0x001B1BF8 File Offset: 0x001AFDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoNotify()
		{
		}

		// Token: 0x0600B592 RID: 46482 RVA: 0x001B1C00 File Offset: 0x001AFE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoNotify(InfrV2InfoNotify other) : this()
		{
			this.infrInfo_ = ((other.infrInfo_ != null) ? other.infrInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B593 RID: 46483 RVA: 0x001B1C35 File Offset: 0x001AFE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoNotify Clone()
		{
			return new InfrV2InfoNotify(this);
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x0600B594 RID: 46484 RVA: 0x001B1C3D File Offset: 0x001AFE3D
		// (set) Token: 0x0600B595 RID: 46485 RVA: 0x001B1C45 File Offset: 0x001AFE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb InfrInfo
		{
			get
			{
				return this.infrInfo_;
			}
			set
			{
				this.infrInfo_ = value;
			}
		}

		// Token: 0x0600B596 RID: 46486 RVA: 0x001B1C4E File Offset: 0x001AFE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2InfoNotify);
		}

		// Token: 0x0600B597 RID: 46487 RVA: 0x001B1C5C File Offset: 0x001AFE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2InfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.InfrInfo, other.InfrInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B598 RID: 46488 RVA: 0x001B1C90 File Offset: 0x001AFE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infrInfo_ != null)
			{
				num ^= this.InfrInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x001B1CCC File Offset: 0x001AFECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B59A RID: 46490 RVA: 0x001B1CD9 File Offset: 0x001AFED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B59B RID: 46491 RVA: 0x001B1CE2 File Offset: 0x001AFEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infrInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x001B1D14 File Offset: 0x001AFF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infrInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InfrInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x001B1D54 File Offset: 0x001AFF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2InfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.infrInfo_ != null)
			{
				if (this.infrInfo_ == null)
				{
					this.InfrInfo = new InfrV2Pb();
				}
				this.InfrInfo.MergeFrom(other.InfrInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B59E RID: 46494 RVA: 0x001B1DA8 File Offset: 0x001AFFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B59F RID: 46495 RVA: 0x001B1DB4 File Offset: 0x001AFFB4
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.infrInfo_ == null)
					{
						this.InfrInfo = new InfrV2Pb();
					}
					input.ReadMessage(this.InfrInfo);
				}
			}
		}

		// Token: 0x040050DF RID: 20703
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050E0 RID: 20704
		public const int InfrInfoFieldNumber = 7;

		// Token: 0x040050E1 RID: 20705
		private InfrV2Pb infrInfo_;
	}
}
