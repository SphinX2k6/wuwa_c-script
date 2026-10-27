using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7A RID: 3194
	[NetMessage(EMessageId.PhantomBattleDebugInfoResponse)]
	public sealed class PhantomBattleDebugInfoResponse : IMessage<PhantomBattleDebugInfoResponse>, IMessage, IEquatable<PhantomBattleDebugInfoResponse>, IDeepCloneable<PhantomBattleDebugInfoResponse>, IBufferMessage
	{
		// Token: 0x06011502 RID: 70914 RVA: 0x00288F26 File Offset: 0x00287126
		[NullableContext(1)]
		public static PhantomBattleDebugInfoResponse Create()
		{
			return new PhantomBattleDebugInfoResponse();
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x06011503 RID: 70915 RVA: 0x00288F2D File Offset: 0x0028712D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x06011504 RID: 70916 RVA: 0x00288F30 File Offset: 0x00287130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011505 RID: 70917 RVA: 0x00288F37 File Offset: 0x00287137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoResponse()
		{
		}

		// Token: 0x06011506 RID: 70918 RVA: 0x00288F4A File Offset: 0x0028714A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoResponse(PhantomBattleDebugInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleDebugGamerInfos_ = other.phantomBattleDebugGamerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011507 RID: 70919 RVA: 0x00288F80 File Offset: 0x00287180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoResponse Clone()
		{
			return new PhantomBattleDebugInfoResponse(this);
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x06011508 RID: 70920 RVA: 0x00288F88 File Offset: 0x00287188
		// (set) Token: 0x06011509 RID: 70921 RVA: 0x00288F90 File Offset: 0x00287190
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

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0601150A RID: 70922 RVA: 0x00288F99 File Offset: 0x00287199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugGamerInfo> PhantomBattleDebugGamerInfos
		{
			get
			{
				return this.phantomBattleDebugGamerInfos_;
			}
		}

		// Token: 0x0601150B RID: 70923 RVA: 0x00288FA1 File Offset: 0x002871A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugInfoResponse);
		}

		// Token: 0x0601150C RID: 70924 RVA: 0x00288FB0 File Offset: 0x002871B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleDebugGamerInfos_.Equals(other.phantomBattleDebugGamerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601150D RID: 70925 RVA: 0x00289000 File Offset: 0x00287200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomBattleDebugGamerInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601150E RID: 70926 RVA: 0x00289053 File Offset: 0x00287253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601150F RID: 70927 RVA: 0x00289060 File Offset: 0x00287260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011510 RID: 70928 RVA: 0x0028906C File Offset: 0x0028726C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleDebugGamerInfos_.WriteTo(ref output, PhantomBattleDebugInfoResponse._repeated_phantomBattleDebugGamerInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011511 RID: 70929 RVA: 0x002890BC File Offset: 0x002872BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomBattleDebugGamerInfos_.CalculateSize(PhantomBattleDebugInfoResponse._repeated_phantomBattleDebugGamerInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011512 RID: 70930 RVA: 0x00289110 File Offset: 0x00287310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomBattleDebugGamerInfos_.Add(other.phantomBattleDebugGamerInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011513 RID: 70931 RVA: 0x0028915D File Offset: 0x0028735D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011514 RID: 70932 RVA: 0x00289168 File Offset: 0x00287368
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
					if (num != 56U)
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
					this.phantomBattleDebugGamerInfos_.AddEntriesFrom(ref input, PhantomBattleDebugInfoResponse._repeated_phantomBattleDebugGamerInfos_codec);
				}
			}
		}

		// Token: 0x04006D77 RID: 28023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D78 RID: 28024
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04006D79 RID: 28025
		private ErrorCode errorCode_;

		// Token: 0x04006D7A RID: 28026
		public const int PhantomBattleDebugGamerInfosFieldNumber = 4;

		// Token: 0x04006D7B RID: 28027
		private static readonly FieldCodec<PhantomBattleDebugGamerInfo> _repeated_phantomBattleDebugGamerInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugGamerInfo>(34U, PhantomBattleDebugGamerInfo.Parser);

		// Token: 0x04006D7C RID: 28028
		private readonly RepeatedField<PhantomBattleDebugGamerInfo> phantomBattleDebugGamerInfos_ = new RepeatedField<PhantomBattleDebugGamerInfo>();
	}
}
