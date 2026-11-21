using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B2 RID: 2482
	public sealed class MatchThreeActivityInfo : IMessage<MatchThreeActivityInfo>, IMessage, IEquatable<MatchThreeActivityInfo>, IDeepCloneable<MatchThreeActivityInfo>, IBufferMessage
	{
		// Token: 0x0600DA2B RID: 55851 RVA: 0x0020123D File Offset: 0x001FF43D
		[NullableContext(1)]
		public static MatchThreeActivityInfo Create()
		{
			return new MatchThreeActivityInfo();
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0600DA2C RID: 55852 RVA: 0x00201244 File Offset: 0x001FF444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x0600DA2D RID: 55853 RVA: 0x00201247 File Offset: 0x001FF447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600DA2E RID: 55854 RVA: 0x0020124E File Offset: 0x001FF44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeActivityInfo()
		{
		}

		// Token: 0x0600DA2F RID: 55855 RVA: 0x00201261 File Offset: 0x001FF461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeActivityInfo(MatchThreeActivityInfo other) : this()
		{
			this.matchThreeLevelInfos_ = other.matchThreeLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x0020128B File Offset: 0x001FF48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeActivityInfo Clone()
		{
			return new MatchThreeActivityInfo(this);
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x0600DA31 RID: 55857 RVA: 0x00201293 File Offset: 0x001FF493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MatchThreeLevelInfo> MatchThreeLevelInfos
		{
			get
			{
				return this.matchThreeLevelInfos_;
			}
		}

		// Token: 0x0600DA32 RID: 55858 RVA: 0x0020129B File Offset: 0x001FF49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeActivityInfo);
		}

		// Token: 0x0600DA33 RID: 55859 RVA: 0x002012A9 File Offset: 0x001FF4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeActivityInfo other)
		{
			return other != null && (other == this || (this.matchThreeLevelInfos_.Equals(other.matchThreeLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x002012DC File Offset: 0x001FF4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.matchThreeLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA35 RID: 55861 RVA: 0x00201310 File Offset: 0x001FF510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA36 RID: 55862 RVA: 0x0020131D File Offset: 0x001FF51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA37 RID: 55863 RVA: 0x00201326 File Offset: 0x001FF526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.matchThreeLevelInfos_.WriteTo(ref output, MatchThreeActivityInfo._repeated_matchThreeLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA38 RID: 55864 RVA: 0x00201350 File Offset: 0x001FF550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.matchThreeLevelInfos_.CalculateSize(MatchThreeActivityInfo._repeated_matchThreeLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA39 RID: 55865 RVA: 0x00201389 File Offset: 0x001FF589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.matchThreeLevelInfos_.Add(other.matchThreeLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA3A RID: 55866 RVA: 0x002013B7 File Offset: 0x001FF5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA3B RID: 55867 RVA: 0x002013C0 File Offset: 0x001FF5C0
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
					this.matchThreeLevelInfos_.AddEntriesFrom(ref input, MatchThreeActivityInfo._repeated_matchThreeLevelInfos_codec);
				}
			}
		}

		// Token: 0x04005B0D RID: 23309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B0E RID: 23310
		public const int MatchThreeLevelInfosFieldNumber = 1;

		// Token: 0x04005B0F RID: 23311
		private static readonly FieldCodec<MatchThreeLevelInfo> _repeated_matchThreeLevelInfos_codec = FieldCodec.ForMessage<MatchThreeLevelInfo>(10U, MatchThreeLevelInfo.Parser);

		// Token: 0x04005B10 RID: 23312
		private readonly RepeatedField<MatchThreeLevelInfo> matchThreeLevelInfos_ = new RepeatedField<MatchThreeLevelInfo>();
	}
}
