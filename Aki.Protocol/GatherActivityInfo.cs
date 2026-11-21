using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A3 RID: 1699
	public sealed class GatherActivityInfo : IMessage<GatherActivityInfo>, IMessage, IEquatable<GatherActivityInfo>, IDeepCloneable<GatherActivityInfo>, IBufferMessage
	{
		// Token: 0x06009C2E RID: 39982 RVA: 0x0017C359 File Offset: 0x0017A559
		[NullableContext(1)]
		public static GatherActivityInfo Create()
		{
			return new GatherActivityInfo();
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06009C2F RID: 39983 RVA: 0x0017C360 File Offset: 0x0017A560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06009C30 RID: 39984 RVA: 0x0017C363 File Offset: 0x0017A563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherActivityInfo.Descriptor;
			}
		}

		// Token: 0x06009C31 RID: 39985 RVA: 0x0017C36A File Offset: 0x0017A56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityInfo()
		{
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x0017C37D File Offset: 0x0017A57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityInfo(GatherActivityInfo other) : this()
		{
			this.gatherTaskDoneInfo_ = other.gatherTaskDoneInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C33 RID: 39987 RVA: 0x0017C3A7 File Offset: 0x0017A5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityInfo Clone()
		{
			return new GatherActivityInfo(this);
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06009C34 RID: 39988 RVA: 0x0017C3AF File Offset: 0x0017A5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GatherTaskDoneInfo> GatherTaskDoneInfo
		{
			get
			{
				return this.gatherTaskDoneInfo_;
			}
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x0017C3B7 File Offset: 0x0017A5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherActivityInfo);
		}

		// Token: 0x06009C36 RID: 39990 RVA: 0x0017C3C5 File Offset: 0x0017A5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherActivityInfo other)
		{
			return other != null && (other == this || (this.gatherTaskDoneInfo_.Equals(other.gatherTaskDoneInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x0017C3F8 File Offset: 0x0017A5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gatherTaskDoneInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x0017C42C File Offset: 0x0017A62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0017C439 File Offset: 0x0017A639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C3A RID: 39994 RVA: 0x0017C442 File Offset: 0x0017A642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gatherTaskDoneInfo_.WriteTo(ref output, GatherActivityInfo._repeated_gatherTaskDoneInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x0017C46C File Offset: 0x0017A66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gatherTaskDoneInfo_.CalculateSize(GatherActivityInfo._repeated_gatherTaskDoneInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x0017C4A5 File Offset: 0x0017A6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.gatherTaskDoneInfo_.Add(other.gatherTaskDoneInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x0017C4D3 File Offset: 0x0017A6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x0017C4DC File Offset: 0x0017A6DC
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
					this.gatherTaskDoneInfo_.AddEntriesFrom(ref input, GatherActivityInfo._repeated_gatherTaskDoneInfo_codec);
				}
			}
		}

		// Token: 0x040049F5 RID: 18933
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049F6 RID: 18934
		public const int GatherTaskDoneInfoFieldNumber = 1;

		// Token: 0x040049F7 RID: 18935
		private static readonly FieldCodec<GatherTaskDoneInfo> _repeated_gatherTaskDoneInfo_codec = FieldCodec.ForMessage<GatherTaskDoneInfo>(10U, Aki.Protocol.GatherTaskDoneInfo.Parser);

		// Token: 0x040049F8 RID: 18936
		private readonly RepeatedField<GatherTaskDoneInfo> gatherTaskDoneInfo_ = new RepeatedField<GatherTaskDoneInfo>();
	}
}
