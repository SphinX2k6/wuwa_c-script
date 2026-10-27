using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000227 RID: 551
	[NetMessage(EMessageId.CalabashSkinTakeOnRequest)]
	public sealed class CalabashSkinTakeOnRequest : IMessage<CalabashSkinTakeOnRequest>, IMessage, IEquatable<CalabashSkinTakeOnRequest>, IDeepCloneable<CalabashSkinTakeOnRequest>, IBufferMessage
	{
		// Token: 0x06003BF9 RID: 15353 RVA: 0x000950FD File Offset: 0x000932FD
		[NullableContext(1)]
		public static CalabashSkinTakeOnRequest Create()
		{
			return new CalabashSkinTakeOnRequest();
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06003BFA RID: 15354 RVA: 0x00095104 File Offset: 0x00093304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x00095107 File Offset: 0x00093307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinTakeOnRequest.Descriptor;
			}
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x0009510E File Offset: 0x0009330E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnRequest()
		{
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00095116 File Offset: 0x00093316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnRequest(CalabashSkinTakeOnRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0009513B File Offset: 0x0009333B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnRequest Clone()
		{
			return new CalabashSkinTakeOnRequest(this);
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06003BFF RID: 15359 RVA: 0x00095143 File Offset: 0x00093343
		// (set) Token: 0x06003C00 RID: 15360 RVA: 0x0009514B File Offset: 0x0009334B
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

		// Token: 0x06003C01 RID: 15361 RVA: 0x00095154 File Offset: 0x00093354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinTakeOnRequest);
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x00095162 File Offset: 0x00093362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinTakeOnRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x00095190 File Offset: 0x00093390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06003C04 RID: 15364 RVA: 0x000951CF File Offset: 0x000933CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x000951DC File Offset: 0x000933DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x000951E5 File Offset: 0x000933E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x00095218 File Offset: 0x00093418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06003C08 RID: 15368 RVA: 0x00095256 File Offset: 0x00093456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinTakeOnRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x00095287 File Offset: 0x00093487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x00095290 File Offset: 0x00093490
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C4B RID: 11339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C4C RID: 11340
		public const int SkinIdFieldNumber = 14;

		// Token: 0x04002C4D RID: 11341
		private int skinId_;
	}
}
