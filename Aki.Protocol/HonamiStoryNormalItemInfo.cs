using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077D RID: 1917
	public sealed class HonamiStoryNormalItemInfo : IMessage<HonamiStoryNormalItemInfo>, IMessage, IEquatable<HonamiStoryNormalItemInfo>, IDeepCloneable<HonamiStoryNormalItemInfo>, IBufferMessage
	{
		// Token: 0x0600AD83 RID: 44419 RVA: 0x001A1461 File Offset: 0x0019F661
		[NullableContext(1)]
		public static HonamiStoryNormalItemInfo Create()
		{
			return new HonamiStoryNormalItemInfo();
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x0600AD84 RID: 44420 RVA: 0x001A1468 File Offset: 0x0019F668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x0600AD85 RID: 44421 RVA: 0x001A146B File Offset: 0x0019F66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryNormalItemInfo.Descriptor;
			}
		}

		// Token: 0x0600AD86 RID: 44422 RVA: 0x001A1472 File Offset: 0x0019F672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryNormalItemInfo()
		{
		}

		// Token: 0x0600AD87 RID: 44423 RVA: 0x001A147A File Offset: 0x0019F67A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryNormalItemInfo(HonamiStoryNormalItemInfo other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD88 RID: 44424 RVA: 0x001A1493 File Offset: 0x0019F693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryNormalItemInfo Clone()
		{
			return new HonamiStoryNormalItemInfo(this);
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x001A149B File Offset: 0x0019F69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryNormalItemInfo);
		}

		// Token: 0x0600AD8A RID: 44426 RVA: 0x001A14A9 File Offset: 0x0019F6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryNormalItemInfo other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x001A14C8 File Offset: 0x0019F6C8
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

		// Token: 0x0600AD8C RID: 44428 RVA: 0x001A14EE File Offset: 0x0019F6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x001A14FB File Offset: 0x0019F6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD8E RID: 44430 RVA: 0x001A1504 File Offset: 0x0019F704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD8F RID: 44431 RVA: 0x001A151C File Offset: 0x0019F71C
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

		// Token: 0x0600AD90 RID: 44432 RVA: 0x001A1542 File Offset: 0x0019F742
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

		// Token: 0x0600AD91 RID: 44433 RVA: 0x001A155F File Offset: 0x0019F75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x001A1568 File Offset: 0x0019F768
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

		// Token: 0x04004ECE RID: 20174
		private UnknownFieldSet _unknownFields;
	}
}
