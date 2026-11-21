using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022C RID: 556
	[NetMessage(EMessageId.CalabashSkinTakeOnRequest)]
	public sealed class CalabashSkinTakeOnRequest : IMessage<CalabashSkinTakeOnRequest>, IMessage, IEquatable<CalabashSkinTakeOnRequest>, IDeepCloneable<CalabashSkinTakeOnRequest>, IBufferMessage
	{
		// Token: 0x06003C9E RID: 15518 RVA: 0x00096D19 File Offset: 0x00094F19
		[NullableContext(1)]
		public static CalabashSkinTakeOnRequest Create()
		{
			return new CalabashSkinTakeOnRequest();
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x00096D20 File Offset: 0x00094F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06003CA0 RID: 15520 RVA: 0x00096D23 File Offset: 0x00094F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinTakeOnRequest.Descriptor;
			}
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00096D2A File Offset: 0x00094F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnRequest()
		{
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00096D32 File Offset: 0x00094F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnRequest(CalabashSkinTakeOnRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x00096D57 File Offset: 0x00094F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnRequest Clone()
		{
			return new CalabashSkinTakeOnRequest(this);
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06003CA4 RID: 15524 RVA: 0x00096D5F File Offset: 0x00094F5F
		// (set) Token: 0x06003CA5 RID: 15525 RVA: 0x00096D67 File Offset: 0x00094F67
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

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00096D70 File Offset: 0x00094F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinTakeOnRequest);
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x00096D7E File Offset: 0x00094F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinTakeOnRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00096DAC File Offset: 0x00094FAC
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

		// Token: 0x06003CA9 RID: 15529 RVA: 0x00096DEB File Offset: 0x00094FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00096DF8 File Offset: 0x00094FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00096E01 File Offset: 0x00095001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00096E34 File Offset: 0x00095034
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

		// Token: 0x06003CAD RID: 15533 RVA: 0x00096E72 File Offset: 0x00095072
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

		// Token: 0x06003CAE RID: 15534 RVA: 0x00096EA3 File Offset: 0x000950A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x00096EAC File Offset: 0x000950AC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CCD RID: 11469
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CCE RID: 11470
		public const int SkinIdFieldNumber = 10;

		// Token: 0x04002CCF RID: 11471
		private int skinId_;
	}
}
