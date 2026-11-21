using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001508 RID: 5384
	[NetMessage(EMessageId.UpdateEnterInfoNotify)]
	public sealed class UpdateEnterInfoNotify : IMessage<UpdateEnterInfoNotify>, IMessage, IEquatable<UpdateEnterInfoNotify>, IDeepCloneable<UpdateEnterInfoNotify>, IBufferMessage
	{
		// Token: 0x0601C888 RID: 116872 RVA: 0x00422D55 File Offset: 0x00420F55
		[NullableContext(1)]
		public static UpdateEnterInfoNotify Create()
		{
			return new UpdateEnterInfoNotify();
		}

		// Token: 0x17006089 RID: 24713
		// (get) Token: 0x0601C889 RID: 116873 RVA: 0x00422D5C File Offset: 0x00420F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700608A RID: 24714
		// (get) Token: 0x0601C88A RID: 116874 RVA: 0x00422D5F File Offset: 0x00420F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEnterInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601C88B RID: 116875 RVA: 0x00422D66 File Offset: 0x00420F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnterInfoNotify()
		{
		}

		// Token: 0x0601C88C RID: 116876 RVA: 0x00422D79 File Offset: 0x00420F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnterInfoNotify(UpdateEnterInfoNotify other) : this()
		{
			this.enterInfos_ = other.enterInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C88D RID: 116877 RVA: 0x00422DA3 File Offset: 0x00420FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnterInfoNotify Clone()
		{
			return new UpdateEnterInfoNotify(this);
		}

		// Token: 0x1700608B RID: 24715
		// (get) Token: 0x0601C88E RID: 116878 RVA: 0x00422DAB File Offset: 0x00420FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstEnterInfoPb> EnterInfos
		{
			get
			{
				return this.enterInfos_;
			}
		}

		// Token: 0x0601C88F RID: 116879 RVA: 0x00422DB3 File Offset: 0x00420FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEnterInfoNotify);
		}

		// Token: 0x0601C890 RID: 116880 RVA: 0x00422DC1 File Offset: 0x00420FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateEnterInfoNotify other)
		{
			return other != null && (other == this || (this.enterInfos_.Equals(other.enterInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C891 RID: 116881 RVA: 0x00422DF4 File Offset: 0x00420FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.enterInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C892 RID: 116882 RVA: 0x00422E28 File Offset: 0x00421028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C893 RID: 116883 RVA: 0x00422E35 File Offset: 0x00421035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C894 RID: 116884 RVA: 0x00422E3E File Offset: 0x0042103E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enterInfos_.WriteTo(ref output, UpdateEnterInfoNotify._repeated_enterInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C895 RID: 116885 RVA: 0x00422E68 File Offset: 0x00421068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.enterInfos_.CalculateSize(UpdateEnterInfoNotify._repeated_enterInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C896 RID: 116886 RVA: 0x00422EA1 File Offset: 0x004210A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateEnterInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.enterInfos_.Add(other.enterInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C897 RID: 116887 RVA: 0x00422ECF File Offset: 0x004210CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C898 RID: 116888 RVA: 0x00422ED8 File Offset: 0x004210D8
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
					this.enterInfos_.AddEntriesFrom(ref input, UpdateEnterInfoNotify._repeated_enterInfos_codec);
				}
			}
		}

		// Token: 0x0400A48B RID: 42123
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A48C RID: 42124
		public const int EnterInfosFieldNumber = 1;

		// Token: 0x0400A48D RID: 42125
		private static readonly FieldCodec<InstEnterInfoPb> _repeated_enterInfos_codec = FieldCodec.ForMessage<InstEnterInfoPb>(10U, InstEnterInfoPb.Parser);

		// Token: 0x0400A48E RID: 42126
		private readonly RepeatedField<InstEnterInfoPb> enterInfos_ = new RepeatedField<InstEnterInfoPb>();
	}
}
