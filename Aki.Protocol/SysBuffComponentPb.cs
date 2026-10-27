using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001315 RID: 4885
	public sealed class SysBuffComponentPb : IMessage<SysBuffComponentPb>, IMessage, IEquatable<SysBuffComponentPb>, IDeepCloneable<SysBuffComponentPb>, IBufferMessage
	{
		// Token: 0x06019F5B RID: 106331 RVA: 0x003C57E0 File Offset: 0x003C39E0
		[NullableContext(1)]
		public static SysBuffComponentPb Create()
		{
			return new SysBuffComponentPb();
		}

		// Token: 0x17005789 RID: 22409
		// (get) Token: 0x06019F5C RID: 106332 RVA: 0x003C57E7 File Offset: 0x003C39E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700578A RID: 22410
		// (get) Token: 0x06019F5D RID: 106333 RVA: 0x003C57EA File Offset: 0x003C39EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysBuffComponentPb.Descriptor;
			}
		}

		// Token: 0x06019F5E RID: 106334 RVA: 0x003C57F1 File Offset: 0x003C39F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffComponentPb()
		{
		}

		// Token: 0x06019F5F RID: 106335 RVA: 0x003C5804 File Offset: 0x003C3A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffComponentPb(SysBuffComponentPb other) : this()
		{
			this.sysBuffInfos_ = other.sysBuffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F60 RID: 106336 RVA: 0x003C582E File Offset: 0x003C3A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffComponentPb Clone()
		{
			return new SysBuffComponentPb(this);
		}

		// Token: 0x1700578B RID: 22411
		// (get) Token: 0x06019F61 RID: 106337 RVA: 0x003C5836 File Offset: 0x003C3A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> SysBuffInfos
		{
			get
			{
				return this.sysBuffInfos_;
			}
		}

		// Token: 0x06019F62 RID: 106338 RVA: 0x003C583E File Offset: 0x003C3A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysBuffComponentPb);
		}

		// Token: 0x06019F63 RID: 106339 RVA: 0x003C584C File Offset: 0x003C3A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysBuffComponentPb other)
		{
			return other != null && (other == this || (this.sysBuffInfos_.Equals(other.sysBuffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F64 RID: 106340 RVA: 0x003C5880 File Offset: 0x003C3A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sysBuffInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F65 RID: 106341 RVA: 0x003C58B4 File Offset: 0x003C3AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F66 RID: 106342 RVA: 0x003C58C1 File Offset: 0x003C3AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F67 RID: 106343 RVA: 0x003C58CA File Offset: 0x003C3ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sysBuffInfos_.WriteTo(ref output, SysBuffComponentPb._repeated_sysBuffInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F68 RID: 106344 RVA: 0x003C58F4 File Offset: 0x003C3AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sysBuffInfos_.CalculateSize(SysBuffComponentPb._repeated_sysBuffInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F69 RID: 106345 RVA: 0x003C592D File Offset: 0x003C3B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SysBuffComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.sysBuffInfos_.Add(other.sysBuffInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F6A RID: 106346 RVA: 0x003C595B File Offset: 0x003C3B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F6B RID: 106347 RVA: 0x003C5964 File Offset: 0x003C3B64
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
					this.sysBuffInfos_.AddEntriesFrom(ref input, SysBuffComponentPb._repeated_sysBuffInfos_codec);
				}
			}
		}

		// Token: 0x040097AD RID: 38829
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097AE RID: 38830
		public const int SysBuffInfosFieldNumber = 1;

		// Token: 0x040097AF RID: 38831
		private static readonly FieldCodec<SysBuffInformation> _repeated_sysBuffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(10U, SysBuffInformation.Parser);

		// Token: 0x040097B0 RID: 38832
		private readonly RepeatedField<SysBuffInformation> sysBuffInfos_ = new RepeatedField<SysBuffInformation>();
	}
}
