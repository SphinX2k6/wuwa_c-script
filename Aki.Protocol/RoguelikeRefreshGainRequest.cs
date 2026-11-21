using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9B RID: 3995
	[NetMessage(EMessageId.RoguelikeRefreshGainRequest)]
	public sealed class RoguelikeRefreshGainRequest : IMessage<RoguelikeRefreshGainRequest>, IMessage, IEquatable<RoguelikeRefreshGainRequest>, IDeepCloneable<RoguelikeRefreshGainRequest>, IBufferMessage
	{
		// Token: 0x0601563C RID: 87612 RVA: 0x0031B531 File Offset: 0x00319731
		[NullableContext(1)]
		public static RoguelikeRefreshGainRequest Create()
		{
			return new RoguelikeRefreshGainRequest();
		}

		// Token: 0x17004751 RID: 18257
		// (get) Token: 0x0601563D RID: 87613 RVA: 0x0031B538 File Offset: 0x00319738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004752 RID: 18258
		// (get) Token: 0x0601563E RID: 87614 RVA: 0x0031B53B File Offset: 0x0031973B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRefreshGainRequest.Descriptor;
			}
		}

		// Token: 0x0601563F RID: 87615 RVA: 0x0031B542 File Offset: 0x00319742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainRequest()
		{
		}

		// Token: 0x06015640 RID: 87616 RVA: 0x0031B54A File Offset: 0x0031974A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainRequest(RoguelikeRefreshGainRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.layer_ = other.layer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015641 RID: 87617 RVA: 0x0031B57B File Offset: 0x0031977B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRefreshGainRequest Clone()
		{
			return new RoguelikeRefreshGainRequest(this);
		}

		// Token: 0x17004753 RID: 18259
		// (get) Token: 0x06015642 RID: 87618 RVA: 0x0031B583 File Offset: 0x00319783
		// (set) Token: 0x06015643 RID: 87619 RVA: 0x0031B58B File Offset: 0x0031978B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x17004754 RID: 18260
		// (get) Token: 0x06015644 RID: 87620 RVA: 0x0031B594 File Offset: 0x00319794
		// (set) Token: 0x06015645 RID: 87621 RVA: 0x0031B59C File Offset: 0x0031979C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Layer
		{
			get
			{
				return this.layer_;
			}
			set
			{
				this.layer_ = value;
			}
		}

		// Token: 0x06015646 RID: 87622 RVA: 0x0031B5A5 File Offset: 0x003197A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRefreshGainRequest);
		}

		// Token: 0x06015647 RID: 87623 RVA: 0x0031B5B3 File Offset: 0x003197B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRefreshGainRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Layer == other.Layer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015648 RID: 87624 RVA: 0x0031B5F4 File Offset: 0x003197F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this.Layer != 0)
			{
				num ^= this.Layer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015649 RID: 87625 RVA: 0x0031B64C File Offset: 0x0031984C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601564A RID: 87626 RVA: 0x0031B659 File Offset: 0x00319859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601564B RID: 87627 RVA: 0x0031B664 File Offset: 0x00319864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Layer != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Layer);
			}
			if (this.BindId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601564C RID: 87628 RVA: 0x0031B6C0 File Offset: 0x003198C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this.Layer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Layer);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601564D RID: 87629 RVA: 0x0031B718 File Offset: 0x00319918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRefreshGainRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			if (other.Layer != 0)
			{
				this.Layer = other.Layer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601564E RID: 87630 RVA: 0x0031B768 File Offset: 0x00319968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601564F RID: 87631 RVA: 0x0031B774 File Offset: 0x00319974
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
				if (num != 24U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BindId = input.ReadInt32();
					}
				}
				else
				{
					this.Layer = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400811C RID: 33052
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400811D RID: 33053
		public const int BindIdFieldNumber = 9;

		// Token: 0x0400811E RID: 33054
		private int bindId_;

		// Token: 0x0400811F RID: 33055
		public const int LayerFieldNumber = 3;

		// Token: 0x04008120 RID: 33056
		private int layer_;
	}
}
