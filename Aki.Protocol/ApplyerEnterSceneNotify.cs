using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000100 RID: 256
	[NetMessage(EMessageId.ApplyerEnterSceneNotify)]
	public sealed class ApplyerEnterSceneNotify : IMessage<ApplyerEnterSceneNotify>, IMessage, IEquatable<ApplyerEnterSceneNotify>, IDeepCloneable<ApplyerEnterSceneNotify>, IBufferMessage
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x0006088F File Offset: 0x0005EA8F
		[NullableContext(1)]
		public static ApplyerEnterSceneNotify Create()
		{
			return new ApplyerEnterSceneNotify();
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x00060896 File Offset: 0x0005EA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x00060899 File Offset: 0x0005EA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyerEnterSceneNotify.Descriptor;
			}
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000608A0 File Offset: 0x0005EAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyerEnterSceneNotify()
		{
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x000608A8 File Offset: 0x0005EAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyerEnterSceneNotify(ApplyerEnterSceneNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000608D9 File Offset: 0x0005EAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyerEnterSceneNotify Clone()
		{
			return new ApplyerEnterSceneNotify(this);
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x000608E1 File Offset: 0x0005EAE1
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x000608E9 File Offset: 0x0005EAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x000608F2 File Offset: 0x0005EAF2
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x000608FA File Offset: 0x0005EAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00060903 File Offset: 0x0005EB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyerEnterSceneNotify);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00060911 File Offset: 0x0005EB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyerEnterSceneNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00060950 File Offset: 0x0005EB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000609AE File Offset: 0x0005EBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x000609BB File Offset: 0x0005EBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000609C4 File Offset: 0x0005EBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00060A20 File Offset: 0x0005EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00060A78 File Offset: 0x0005EC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyerEnterSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00060AC8 File Offset: 0x0005ECC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00060AD4 File Offset: 0x0005ECD4
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
				if (num != 56U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002587 RID: 9607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002588 RID: 9608
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002589 RID: 9609
		private ErrorCode errorCode_;

		// Token: 0x0400258A RID: 9610
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x0400258B RID: 9611
		private int playerId_;
	}
}
