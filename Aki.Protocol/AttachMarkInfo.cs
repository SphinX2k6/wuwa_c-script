using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000123 RID: 291
	public sealed class AttachMarkInfo : IMessage<AttachMarkInfo>, IMessage, IEquatable<AttachMarkInfo>, IDeepCloneable<AttachMarkInfo>, IBufferMessage
	{
		// Token: 0x0600275E RID: 10078 RVA: 0x000687E9 File Offset: 0x000669E9
		[NullableContext(1)]
		public static AttachMarkInfo Create()
		{
			return new AttachMarkInfo();
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000687F0 File Offset: 0x000669F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x000687F3 File Offset: 0x000669F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachMarkInfo.Descriptor;
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000687FA File Offset: 0x000669FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo()
		{
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0006880D File Offset: 0x00066A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo(AttachMarkInfo other) : this()
		{
			this.markPointInfo_ = other.markPointInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00068837 File Offset: 0x00066A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachMarkInfo Clone()
		{
			return new AttachMarkInfo(this);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x0006883F File Offset: 0x00066A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MarkPointInfo> MarkPointInfo
		{
			get
			{
				return this.markPointInfo_;
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00068847 File Offset: 0x00066A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachMarkInfo);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00068855 File Offset: 0x00066A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachMarkInfo other)
		{
			return other != null && (other == this || (this.markPointInfo_.Equals(other.markPointInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00068888 File Offset: 0x00066A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markPointInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000688BC File Offset: 0x00066ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000688C9 File Offset: 0x00066AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000688D2 File Offset: 0x00066AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markPointInfo_.WriteTo(ref output, AttachMarkInfo._repeated_markPointInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000688FC File Offset: 0x00066AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markPointInfo_.CalculateSize(AttachMarkInfo._repeated_markPointInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00068935 File Offset: 0x00066B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttachMarkInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.markPointInfo_.Add(other.markPointInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00068963 File Offset: 0x00066B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0006896C File Offset: 0x00066B6C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markPointInfo_.AddEntriesFrom(ref input, AttachMarkInfo._repeated_markPointInfo_codec);
				}
			}
		}

		// Token: 0x040026AE RID: 9902
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026AF RID: 9903
		public const int MarkPointInfoFieldNumber = 1;

		// Token: 0x040026B0 RID: 9904
		private static readonly FieldCodec<MarkPointInfo> _repeated_markPointInfo_codec = FieldCodec.ForMessage<MarkPointInfo>(10U, Aki.Protocol.MarkPointInfo.Parser);

		// Token: 0x040026B1 RID: 9905
		private readonly RepeatedField<MarkPointInfo> markPointInfo_ = new RepeatedField<MarkPointInfo>();
	}
}
