using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B6 RID: 1462
	[NetMessage(EMessageId.FloroRanchPlaySelectCardGroupResponse)]
	public sealed class FloroRanchPlaySelectCardGroupResponse : IMessage<FloroRanchPlaySelectCardGroupResponse>, IMessage, IEquatable<FloroRanchPlaySelectCardGroupResponse>, IDeepCloneable<FloroRanchPlaySelectCardGroupResponse>, IBufferMessage
	{
		// Token: 0x0600879E RID: 34718 RVA: 0x001476C5 File Offset: 0x001458C5
		[NullableContext(1)]
		public static FloroRanchPlaySelectCardGroupResponse Create()
		{
			return new FloroRanchPlaySelectCardGroupResponse();
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x0600879F RID: 34719 RVA: 0x001476CC File Offset: 0x001458CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060087A0 RID: 34720 RVA: 0x001476CF File Offset: 0x001458CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlaySelectCardGroupResponse.Descriptor;
			}
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x001476D6 File Offset: 0x001458D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupResponse()
		{
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x001476E9 File Offset: 0x001458E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupResponse(FloroRanchPlaySelectCardGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newPhantoms_ = other.newPhantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087A3 RID: 34723 RVA: 0x0014771F File Offset: 0x0014591F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupResponse Clone()
		{
			return new FloroRanchPlaySelectCardGroupResponse(this);
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060087A4 RID: 34724 RVA: 0x00147727 File Offset: 0x00145927
		// (set) Token: 0x060087A5 RID: 34725 RVA: 0x0014772F File Offset: 0x0014592F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060087A6 RID: 34726 RVA: 0x00147738 File Offset: 0x00145938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> NewPhantoms
		{
			get
			{
				return this.newPhantoms_;
			}
		}

		// Token: 0x060087A7 RID: 34727 RVA: 0x00147740 File Offset: 0x00145940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlaySelectCardGroupResponse);
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x00147750 File Offset: 0x00145950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlaySelectCardGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.newPhantoms_.Equals(other.newPhantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x001477A0 File Offset: 0x001459A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.newPhantoms_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x001477F3 File Offset: 0x001459F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x00147800 File Offset: 0x00145A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x0014780C File Offset: 0x00145A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.newPhantoms_.WriteTo(ref output, FloroRanchPlaySelectCardGroupResponse._repeated_newPhantoms_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x0014785C File Offset: 0x00145A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.newPhantoms_.CalculateSize(FloroRanchPlaySelectCardGroupResponse._repeated_newPhantoms_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x001478B0 File Offset: 0x00145AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlaySelectCardGroupResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.newPhantoms_.Add(other.newPhantoms_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x001478FD File Offset: 0x00145AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x00147908 File Offset: 0x00145B08
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
				if (num != 34U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.newPhantoms_.AddEntriesFrom(ref input, FloroRanchPlaySelectCardGroupResponse._repeated_newPhantoms_codec);
				}
			}
		}

		// Token: 0x04004358 RID: 17240
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004359 RID: 17241
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400435A RID: 17242
		private ErrorCode errorCode_;

		// Token: 0x0400435B RID: 17243
		public const int NewPhantomsFieldNumber = 4;

		// Token: 0x0400435C RID: 17244
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_newPhantoms_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(34U, FloroRanchPlayUnit.Parser);

		// Token: 0x0400435D RID: 17245
		private readonly RepeatedField<FloroRanchPlayUnit> newPhantoms_ = new RepeatedField<FloroRanchPlayUnit>();
	}
}
