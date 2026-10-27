using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CB RID: 1739
	public sealed class GetItemCount : IMessage<GetItemCount>, IMessage, IEquatable<GetItemCount>, IDeepCloneable<GetItemCount>, IBufferMessage
	{
		// Token: 0x06009F01 RID: 40705 RVA: 0x001819BD File Offset: 0x0017FBBD
		[NullableContext(1)]
		public static GetItemCount Create()
		{
			return new GetItemCount();
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06009F02 RID: 40706 RVA: 0x001819C4 File Offset: 0x0017FBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetItemCount> Parser
		{
			get
			{
				return GetItemCount._parser;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06009F03 RID: 40707 RVA: 0x001819CB File Offset: 0x0017FBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06009F04 RID: 40708 RVA: 0x001819CE File Offset: 0x0017FBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetItemCount.Descriptor;
			}
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x001819D5 File Offset: 0x0017FBD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemCount()
		{
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x001819DD File Offset: 0x0017FBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemCount(GetItemCount other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x00181A0E File Offset: 0x0017FC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemCount Clone()
		{
			return new GetItemCount(this);
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06009F08 RID: 40712 RVA: 0x00181A16 File Offset: 0x0017FC16
		// (set) Token: 0x06009F09 RID: 40713 RVA: 0x00181A1E File Offset: 0x0017FC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06009F0A RID: 40714 RVA: 0x00181A27 File Offset: 0x0017FC27
		// (set) Token: 0x06009F0B RID: 40715 RVA: 0x00181A2F File Offset: 0x0017FC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06009F0C RID: 40716 RVA: 0x00181A38 File Offset: 0x0017FC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetItemCount);
		}

		// Token: 0x06009F0D RID: 40717 RVA: 0x00181A46 File Offset: 0x0017FC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetItemCount other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F0E RID: 40718 RVA: 0x00181A84 File Offset: 0x0017FC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F0F RID: 40719 RVA: 0x00181ADC File Offset: 0x0017FCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F10 RID: 40720 RVA: 0x00181AE9 File Offset: 0x0017FCE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F11 RID: 40721 RVA: 0x00181AF4 File Offset: 0x0017FCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F12 RID: 40722 RVA: 0x00181B4C File Offset: 0x0017FD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x00181BA4 File Offset: 0x0017FDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetItemCount other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F14 RID: 40724 RVA: 0x00181BF4 File Offset: 0x0017FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F15 RID: 40725 RVA: 0x00181C00 File Offset: 0x0017FE00
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A51 RID: 19025
		private static readonly MessageParser<GetItemCount> _parser = new MessageParser<GetItemCount>(() => new GetItemCount());

		// Token: 0x04004A52 RID: 19026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A53 RID: 19027
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004A54 RID: 19028
		private int itemId_;

		// Token: 0x04004A55 RID: 19029
		public const int CountFieldNumber = 2;

		// Token: 0x04004A56 RID: 19030
		private int count_;
	}
}
