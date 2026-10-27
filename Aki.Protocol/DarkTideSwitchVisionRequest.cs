using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B5 RID: 949
	[NetMessage(EMessageId.DarkTideSwitchVisionRequest)]
	public sealed class DarkTideSwitchVisionRequest : IMessage<DarkTideSwitchVisionRequest>, IMessage, IEquatable<DarkTideSwitchVisionRequest>, IDeepCloneable<DarkTideSwitchVisionRequest>, IBufferMessage
	{
		// Token: 0x06005D15 RID: 23829 RVA: 0x000E2010 File Offset: 0x000E0210
		[NullableContext(1)]
		public static DarkTideSwitchVisionRequest Create()
		{
			return new DarkTideSwitchVisionRequest();
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x000E2017 File Offset: 0x000E0217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06005D17 RID: 23831 RVA: 0x000E201A File Offset: 0x000E021A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideSwitchVisionRequest.Descriptor;
			}
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x000E2021 File Offset: 0x000E0221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideSwitchVisionRequest()
		{
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x000E2029 File Offset: 0x000E0229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideSwitchVisionRequest(DarkTideSwitchVisionRequest other) : this()
		{
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x000E204E File Offset: 0x000E024E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideSwitchVisionRequest Clone()
		{
			return new DarkTideSwitchVisionRequest(this);
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06005D1B RID: 23835 RVA: 0x000E2056 File Offset: 0x000E0256
		// (set) Token: 0x06005D1C RID: 23836 RVA: 0x000E205E File Offset: 0x000E025E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x000E2067 File Offset: 0x000E0267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideSwitchVisionRequest);
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x000E2075 File Offset: 0x000E0275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideSwitchVisionRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x000E20A4 File Offset: 0x000E02A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x000E20E3 File Offset: 0x000E02E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x000E20F0 File Offset: 0x000E02F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x000E20F9 File Offset: 0x000E02F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x000E212C File Offset: 0x000E032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x000E216A File Offset: 0x000E036A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideSwitchVisionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x000E219B File Offset: 0x000E039B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x000E21A4 File Offset: 0x000E03A4
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
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003675 RID: 13941
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003676 RID: 13942
		public const int IndexFieldNumber = 15;

		// Token: 0x04003677 RID: 13943
		private int index_;
	}
}
