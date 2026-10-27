using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035D RID: 861
	[NetMessage(EMessageId.DangoBrawlInstPrepareNotify)]
	public sealed class DangoBrawlInstPrepareNotify : IMessage<DangoBrawlInstPrepareNotify>, IMessage, IEquatable<DangoBrawlInstPrepareNotify>, IDeepCloneable<DangoBrawlInstPrepareNotify>, IBufferMessage
	{
		// Token: 0x060055FE RID: 22014 RVA: 0x000D252E File Offset: 0x000D072E
		[NullableContext(1)]
		public static DangoBrawlInstPrepareNotify Create()
		{
			return new DangoBrawlInstPrepareNotify();
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060055FF RID: 22015 RVA: 0x000D2535 File Offset: 0x000D0735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x000D2538 File Offset: 0x000D0738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlInstPrepareNotify.Descriptor;
			}
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x000D253F File Offset: 0x000D073F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstPrepareNotify()
		{
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x000D2547 File Offset: 0x000D0747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstPrepareNotify(DangoBrawlInstPrepareNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x000D2560 File Offset: 0x000D0760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlInstPrepareNotify Clone()
		{
			return new DangoBrawlInstPrepareNotify(this);
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x000D2568 File Offset: 0x000D0768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlInstPrepareNotify);
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x000D2576 File Offset: 0x000D0776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlInstPrepareNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x000D2594 File Offset: 0x000D0794
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

		// Token: 0x06005607 RID: 22023 RVA: 0x000D25BA File Offset: 0x000D07BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x000D25C7 File Offset: 0x000D07C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x000D25D0 File Offset: 0x000D07D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x000D25E8 File Offset: 0x000D07E8
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

		// Token: 0x0600560B RID: 22027 RVA: 0x000D260E File Offset: 0x000D080E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlInstPrepareNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x000D262B File Offset: 0x000D082B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x000D2634 File Offset: 0x000D0834
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

		// Token: 0x04003461 RID: 13409
		private UnknownFieldSet _unknownFields;
	}
}
