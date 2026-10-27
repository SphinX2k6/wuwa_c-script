using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A4 RID: 676
	public sealed class ClientStorageLongData : IMessage<ClientStorageLongData>, IMessage, IEquatable<ClientStorageLongData>, IDeepCloneable<ClientStorageLongData>, IBufferMessage
	{
		// Token: 0x06004646 RID: 17990 RVA: 0x000ACF02 File Offset: 0x000AB102
		[NullableContext(1)]
		public static ClientStorageLongData Create()
		{
			return new ClientStorageLongData();
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x000ACF09 File Offset: 0x000AB109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x000ACF0C File Offset: 0x000AB10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageLongData.Descriptor;
			}
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x000ACF13 File Offset: 0x000AB113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageLongData()
		{
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x000ACF1B File Offset: 0x000AB11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageLongData(ClientStorageLongData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x000ACF40 File Offset: 0x000AB140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageLongData Clone()
		{
			return new ClientStorageLongData(this);
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x000ACF48 File Offset: 0x000AB148
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x000ACF50 File Offset: 0x000AB150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x000ACF59 File Offset: 0x000AB159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageLongData);
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x000ACF67 File Offset: 0x000AB167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageLongData other)
		{
			return other != null && (other == this || (this.Data == other.Data && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x000ACF98 File Offset: 0x000AB198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Data != 0L)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x000ACFD7 File Offset: 0x000AB1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x000ACFE4 File Offset: 0x000AB1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x000ACFED File Offset: 0x000AB1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Data != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x000AD020 File Offset: 0x000AB220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Data != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x000AD05E File Offset: 0x000AB25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageLongData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Data != 0L)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x000AD08F File Offset: 0x000AB28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x000AD098 File Offset: 0x000AB298
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Data = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002F4A RID: 12106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F4B RID: 12107
		public const int DataFieldNumber = 1;

		// Token: 0x04002F4C RID: 12108
		private long data_;
	}
}
