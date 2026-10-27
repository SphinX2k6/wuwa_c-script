using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000702 RID: 1794
	public sealed class GolemCrackActivityInfo : IMessage<GolemCrackActivityInfo>, IMessage, IEquatable<GolemCrackActivityInfo>, IDeepCloneable<GolemCrackActivityInfo>, IBufferMessage
	{
		// Token: 0x0600A34A RID: 41802 RVA: 0x0018A7ED File Offset: 0x001889ED
		[NullableContext(1)]
		public static GolemCrackActivityInfo Create()
		{
			return new GolemCrackActivityInfo();
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x0600A34B RID: 41803 RVA: 0x0018A7F4 File Offset: 0x001889F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x0600A34C RID: 41804 RVA: 0x0018A7F7 File Offset: 0x001889F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GolemCrackActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x0018A7FE File Offset: 0x001889FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackActivityInfo()
		{
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x0018A811 File Offset: 0x00188A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackActivityInfo(GolemCrackActivityInfo other) : this()
		{
			this.golemCrackLevelInfos_ = other.golemCrackLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x0018A83B File Offset: 0x00188A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GolemCrackActivityInfo Clone()
		{
			return new GolemCrackActivityInfo(this);
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x0600A350 RID: 41808 RVA: 0x0018A843 File Offset: 0x00188A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GolemCrackLevelInfo> GolemCrackLevelInfos
		{
			get
			{
				return this.golemCrackLevelInfos_;
			}
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x0018A84B File Offset: 0x00188A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GolemCrackActivityInfo);
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x0018A859 File Offset: 0x00188A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GolemCrackActivityInfo other)
		{
			return other != null && (other == this || (this.golemCrackLevelInfos_.Equals(other.golemCrackLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x0018A88C File Offset: 0x00188A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.golemCrackLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x0018A8C0 File Offset: 0x00188AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x0018A8CD File Offset: 0x00188ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x0018A8D6 File Offset: 0x00188AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.golemCrackLevelInfos_.WriteTo(ref output, GolemCrackActivityInfo._repeated_golemCrackLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x0018A900 File Offset: 0x00188B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.golemCrackLevelInfos_.CalculateSize(GolemCrackActivityInfo._repeated_golemCrackLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x0018A939 File Offset: 0x00188B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GolemCrackActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.golemCrackLevelInfos_.Add(other.golemCrackLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x0018A967 File Offset: 0x00188B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x0018A970 File Offset: 0x00188B70
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
					this.golemCrackLevelInfos_.AddEntriesFrom(ref input, GolemCrackActivityInfo._repeated_golemCrackLevelInfos_codec);
				}
			}
		}

		// Token: 0x04004B7C RID: 19324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B7D RID: 19325
		public const int GolemCrackLevelInfosFieldNumber = 1;

		// Token: 0x04004B7E RID: 19326
		private static readonly FieldCodec<GolemCrackLevelInfo> _repeated_golemCrackLevelInfos_codec = FieldCodec.ForMessage<GolemCrackLevelInfo>(10U, GolemCrackLevelInfo.Parser);

		// Token: 0x04004B7F RID: 19327
		private readonly RepeatedField<GolemCrackLevelInfo> golemCrackLevelInfos_ = new RepeatedField<GolemCrackLevelInfo>();
	}
}
