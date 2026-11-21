using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007D RID: 125
	[NetMessage(EMessageId.ActivateBuffRequest)]
	public sealed class ActivateBuffRequest : IMessage<ActivateBuffRequest>, IMessage, IEquatable<ActivateBuffRequest>, IDeepCloneable<ActivateBuffRequest>, IBufferMessage
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x000409A8 File Offset: 0x0003EBA8
		[NullableContext(1)]
		public static ActivateBuffRequest Create()
		{
			return new ActivateBuffRequest();
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x000409AF File Offset: 0x0003EBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x000409B2 File Offset: 0x0003EBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffRequest.Descriptor;
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000409B9 File Offset: 0x0003EBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest()
		{
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000409C1 File Offset: 0x0003EBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest(ActivateBuffRequest other) : this()
		{
			this.handle_ = other.handle_;
			this.on_ = other.on_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000409F2 File Offset: 0x0003EBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffRequest Clone()
		{
			return new ActivateBuffRequest(this);
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x000409FA File Offset: 0x0003EBFA
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x00040A02 File Offset: 0x0003EC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x00040A0B File Offset: 0x0003EC0B
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00040A13 File Offset: 0x0003EC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool On
		{
			get
			{
				return this.on_;
			}
			set
			{
				this.on_ = value;
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00040A1C File Offset: 0x0003EC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffRequest);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00040A2A File Offset: 0x0003EC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffRequest other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.On == other.On && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00040A68 File Offset: 0x0003EC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.On)
			{
				num ^= this.On.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00040AC0 File Offset: 0x0003ECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00040ACD File Offset: 0x0003ECCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00040AD8 File Offset: 0x0003ECD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.On)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.On);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Handle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00040B34 File Offset: 0x0003ED34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.On)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00040B80 File Offset: 0x0003ED80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivateBuffRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.On)
			{
				this.On = other.On;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00040BD0 File Offset: 0x0003EDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00040BDC File Offset: 0x0003EDDC
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Handle = input.ReadInt32();
					}
				}
				else
				{
					this.On = input.ReadBool();
				}
			}
		}

		// Token: 0x040021DE RID: 8670
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021DF RID: 8671
		public const int HandleFieldNumber = 5;

		// Token: 0x040021E0 RID: 8672
		private int handle_;

		// Token: 0x040021E1 RID: 8673
		public const int OnFieldNumber = 4;

		// Token: 0x040021E2 RID: 8674
		private bool on_;
	}
}
