using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000228 RID: 552
	[NetMessage(EMessageId.CalabashSkinTakeOnResponse)]
	public sealed class CalabashSkinTakeOnResponse : IMessage<CalabashSkinTakeOnResponse>, IMessage, IEquatable<CalabashSkinTakeOnResponse>, IDeepCloneable<CalabashSkinTakeOnResponse>, IBufferMessage
	{
		// Token: 0x06003C0B RID: 15371 RVA: 0x000952D5 File Offset: 0x000934D5
		[NullableContext(1)]
		public static CalabashSkinTakeOnResponse Create()
		{
			return new CalabashSkinTakeOnResponse();
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x000952DC File Offset: 0x000934DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x000952DF File Offset: 0x000934DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinTakeOnResponse.Descriptor;
			}
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x000952E6 File Offset: 0x000934E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnResponse()
		{
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x000952EE File Offset: 0x000934EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnResponse(CalabashSkinTakeOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x0009531F File Offset: 0x0009351F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnResponse Clone()
		{
			return new CalabashSkinTakeOnResponse(this);
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00095327 File Offset: 0x00093527
		// (set) Token: 0x06003C12 RID: 15378 RVA: 0x0009532F File Offset: 0x0009352F
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

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00095338 File Offset: 0x00093538
		// (set) Token: 0x06003C14 RID: 15380 RVA: 0x00095340 File Offset: 0x00093540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x00095349 File Offset: 0x00093549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinTakeOnResponse);
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00095357 File Offset: 0x00093557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinTakeOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00095398 File Offset: 0x00093598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x000953F6 File Offset: 0x000935F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00095403 File Offset: 0x00093603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0009540C File Offset: 0x0009360C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkinId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x00095468 File Offset: 0x00093668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x000954C0 File Offset: 0x000936C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinTakeOnResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x00095510 File Offset: 0x00093710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x0009551C File Offset: 0x0009371C
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
					if (num != 80U)
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
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C4E RID: 11342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C4F RID: 11343
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002C50 RID: 11344
		private ErrorCode errorCode_;

		// Token: 0x04002C51 RID: 11345
		public const int SkinIdFieldNumber = 7;

		// Token: 0x04002C52 RID: 11346
		private int skinId_;
	}
}
