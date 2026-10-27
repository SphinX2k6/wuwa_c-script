using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000791 RID: 1937
	public sealed class HonamiStoryNormalItemInfo : IMessage<HonamiStoryNormalItemInfo>, IMessage, IEquatable<HonamiStoryNormalItemInfo>, IDeepCloneable<HonamiStoryNormalItemInfo>, IBufferMessage
	{
		// Token: 0x0600AED9 RID: 44761 RVA: 0x001A3E89 File Offset: 0x001A2089
		[NullableContext(1)]
		public static HonamiStoryNormalItemInfo Create()
		{
			return new HonamiStoryNormalItemInfo();
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600AEDA RID: 44762 RVA: 0x001A3E90 File Offset: 0x001A2090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600AEDB RID: 44763 RVA: 0x001A3E93 File Offset: 0x001A2093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryNormalItemInfo.Descriptor;
			}
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x001A3E9A File Offset: 0x001A209A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryNormalItemInfo()
		{
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x001A3EA2 File Offset: 0x001A20A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryNormalItemInfo(HonamiStoryNormalItemInfo other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x001A3EBB File Offset: 0x001A20BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryNormalItemInfo Clone()
		{
			return new HonamiStoryNormalItemInfo(this);
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x001A3EC3 File Offset: 0x001A20C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryNormalItemInfo);
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x001A3ED1 File Offset: 0x001A20D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryNormalItemInfo other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x001A3EF0 File Offset: 0x001A20F0
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

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x001A3F16 File Offset: 0x001A2116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x001A3F23 File Offset: 0x001A2123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x001A3F2C File Offset: 0x001A212C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x001A3F44 File Offset: 0x001A2144
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

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x001A3F6A File Offset: 0x001A216A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryNormalItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x001A3F87 File Offset: 0x001A2187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x001A3F90 File Offset: 0x001A2190
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

		// Token: 0x04004ED5 RID: 20181
		private UnknownFieldSet _unknownFields;
	}
}
