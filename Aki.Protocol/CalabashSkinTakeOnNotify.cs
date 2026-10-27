using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000226 RID: 550
	[NetMessage(EMessageId.CalabashSkinTakeOnNotify)]
	public sealed class CalabashSkinTakeOnNotify : IMessage<CalabashSkinTakeOnNotify>, IMessage, IEquatable<CalabashSkinTakeOnNotify>, IDeepCloneable<CalabashSkinTakeOnNotify>, IBufferMessage
	{
		// Token: 0x06003BE7 RID: 15335 RVA: 0x00094F24 File Offset: 0x00093124
		[NullableContext(1)]
		public static CalabashSkinTakeOnNotify Create()
		{
			return new CalabashSkinTakeOnNotify();
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x00094F2B File Offset: 0x0009312B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x00094F2E File Offset: 0x0009312E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinTakeOnNotify.Descriptor;
			}
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00094F35 File Offset: 0x00093135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnNotify()
		{
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00094F3D File Offset: 0x0009313D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnNotify(CalabashSkinTakeOnNotify other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x00094F62 File Offset: 0x00093162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnNotify Clone()
		{
			return new CalabashSkinTakeOnNotify(this);
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x00094F6A File Offset: 0x0009316A
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x00094F72 File Offset: 0x00093172
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

		// Token: 0x06003BEF RID: 15343 RVA: 0x00094F7B File Offset: 0x0009317B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinTakeOnNotify);
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x00094F89 File Offset: 0x00093189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinTakeOnNotify other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x00094FB8 File Offset: 0x000931B8
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

		// Token: 0x06003BF2 RID: 15346 RVA: 0x00094FF7 File Offset: 0x000931F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x00095004 File Offset: 0x00093204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x0009500D File Offset: 0x0009320D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x00095040 File Offset: 0x00093240
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

		// Token: 0x06003BF6 RID: 15350 RVA: 0x0009507E File Offset: 0x0009327E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinTakeOnNotify other)
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

		// Token: 0x06003BF7 RID: 15351 RVA: 0x000950AF File Offset: 0x000932AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x000950B8 File Offset: 0x000932B8
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
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C48 RID: 11336
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C49 RID: 11337
		public const int SkinIdFieldNumber = 11;

		// Token: 0x04002C4A RID: 11338
		private int skinId_;
	}
}
