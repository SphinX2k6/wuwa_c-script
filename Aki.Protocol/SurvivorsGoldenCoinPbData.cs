using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C9 RID: 4809
	public sealed class SurvivorsGoldenCoinPbData : IMessage<SurvivorsGoldenCoinPbData>, IMessage, IEquatable<SurvivorsGoldenCoinPbData>, IDeepCloneable<SurvivorsGoldenCoinPbData>, IBufferMessage
	{
		// Token: 0x0601996D RID: 104813 RVA: 0x003B858A File Offset: 0x003B678A
		[NullableContext(1)]
		public static SurvivorsGoldenCoinPbData Create()
		{
			return new SurvivorsGoldenCoinPbData();
		}

		// Token: 0x17005653 RID: 22099
		// (get) Token: 0x0601996E RID: 104814 RVA: 0x003B8591 File Offset: 0x003B6791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005654 RID: 22100
		// (get) Token: 0x0601996F RID: 104815 RVA: 0x003B8594 File Offset: 0x003B6794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGoldenCoinPbData.Descriptor;
			}
		}

		// Token: 0x06019970 RID: 104816 RVA: 0x003B859B File Offset: 0x003B679B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinPbData()
		{
		}

		// Token: 0x06019971 RID: 104817 RVA: 0x003B85A3 File Offset: 0x003B67A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinPbData(SurvivorsGoldenCoinPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019972 RID: 104818 RVA: 0x003B85BC File Offset: 0x003B67BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinPbData Clone()
		{
			return new SurvivorsGoldenCoinPbData(this);
		}

		// Token: 0x06019973 RID: 104819 RVA: 0x003B85C4 File Offset: 0x003B67C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGoldenCoinPbData);
		}

		// Token: 0x06019974 RID: 104820 RVA: 0x003B85D2 File Offset: 0x003B67D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGoldenCoinPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019975 RID: 104821 RVA: 0x003B85F0 File Offset: 0x003B67F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019976 RID: 104822 RVA: 0x003B8616 File Offset: 0x003B6816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019977 RID: 104823 RVA: 0x003B8623 File Offset: 0x003B6823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019978 RID: 104824 RVA: 0x003B862C File Offset: 0x003B682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019979 RID: 104825 RVA: 0x003B8644 File Offset: 0x003B6844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601997A RID: 104826 RVA: 0x003B866A File Offset: 0x003B686A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsGoldenCoinPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601997B RID: 104827 RVA: 0x003B8687 File Offset: 0x003B6887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601997C RID: 104828 RVA: 0x003B8690 File Offset: 0x003B6890
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009617 RID: 38423
		private UnknownFieldSet _unknownFields;
	}
}
