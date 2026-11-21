using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000255 RID: 597
	[NetMessage(EMessageId.ChangeHeadPhotoRequest)]
	public sealed class ChangeHeadPhotoRequest : IMessage<ChangeHeadPhotoRequest>, IMessage, IEquatable<ChangeHeadPhotoRequest>, IDeepCloneable<ChangeHeadPhotoRequest>, IBufferMessage
	{
		// Token: 0x06003FC4 RID: 16324 RVA: 0x0009D376 File Offset: 0x0009B576
		[NullableContext(1)]
		public static ChangeHeadPhotoRequest Create()
		{
			return new ChangeHeadPhotoRequest();
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x0009D37D File Offset: 0x0009B57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x0009D380 File Offset: 0x0009B580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeHeadPhotoRequest.Descriptor;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x0009D387 File Offset: 0x0009B587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoRequest()
		{
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x0009D38F File Offset: 0x0009B58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoRequest(ChangeHeadPhotoRequest other) : this()
		{
			this.headPhotoId_ = other.headPhotoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0009D3B4 File Offset: 0x0009B5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoRequest Clone()
		{
			return new ChangeHeadPhotoRequest(this);
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x0009D3BC File Offset: 0x0009B5BC
		// (set) Token: 0x06003FCB RID: 16331 RVA: 0x0009D3C4 File Offset: 0x0009B5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadPhotoId
		{
			get
			{
				return this.headPhotoId_;
			}
			set
			{
				this.headPhotoId_ = value;
			}
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x0009D3CD File Offset: 0x0009B5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeHeadPhotoRequest);
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x0009D3DB File Offset: 0x0009B5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeHeadPhotoRequest other)
		{
			return other != null && (other == this || (this.HeadPhotoId == other.HeadPhotoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x0009D40C File Offset: 0x0009B60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadPhotoId != 0)
			{
				num ^= this.HeadPhotoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x0009D44B File Offset: 0x0009B64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x0009D458 File Offset: 0x0009B658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x0009D461 File Offset: 0x0009B661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadPhotoId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x0009D494 File Offset: 0x0009B694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadPhotoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x0009D4D2 File Offset: 0x0009B6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeHeadPhotoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadPhotoId != 0)
			{
				this.HeadPhotoId = other.HeadPhotoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x0009D503 File Offset: 0x0009B703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x0009D50C File Offset: 0x0009B70C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HeadPhotoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D8E RID: 11662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D8F RID: 11663
		public const int HeadPhotoIdFieldNumber = 15;

		// Token: 0x04002D90 RID: 11664
		private int headPhotoId_;
	}
}
