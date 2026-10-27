using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BC RID: 4540
	[NetMessage(EMessageId.SelectBabelActivityDeTermRequest)]
	public sealed class SelectBabelActivityDeTermRequest : IMessage<SelectBabelActivityDeTermRequest>, IMessage, IEquatable<SelectBabelActivityDeTermRequest>, IDeepCloneable<SelectBabelActivityDeTermRequest>, IBufferMessage
	{
		// Token: 0x060183A0 RID: 99232 RVA: 0x00386E67 File Offset: 0x00385067
		[NullableContext(1)]
		public static SelectBabelActivityDeTermRequest Create()
		{
			return new SelectBabelActivityDeTermRequest();
		}

		// Token: 0x1700519F RID: 20895
		// (get) Token: 0x060183A1 RID: 99233 RVA: 0x00386E6E File Offset: 0x0038506E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051A0 RID: 20896
		// (get) Token: 0x060183A2 RID: 99234 RVA: 0x00386E71 File Offset: 0x00385071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectBabelActivityDeTermRequest.Descriptor;
			}
		}

		// Token: 0x060183A3 RID: 99235 RVA: 0x00386E78 File Offset: 0x00385078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermRequest()
		{
		}

		// Token: 0x060183A4 RID: 99236 RVA: 0x00386E8B File Offset: 0x0038508B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermRequest(SelectBabelActivityDeTermRequest other) : this()
		{
			this.babelTowerLevelId_ = other.babelTowerLevelId_;
			this.babelDeTermId_ = other.babelDeTermId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060183A5 RID: 99237 RVA: 0x00386EC1 File Offset: 0x003850C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectBabelActivityDeTermRequest Clone()
		{
			return new SelectBabelActivityDeTermRequest(this);
		}

		// Token: 0x170051A1 RID: 20897
		// (get) Token: 0x060183A6 RID: 99238 RVA: 0x00386EC9 File Offset: 0x003850C9
		// (set) Token: 0x060183A7 RID: 99239 RVA: 0x00386ED1 File Offset: 0x003850D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BabelTowerLevelId
		{
			get
			{
				return this.babelTowerLevelId_;
			}
			set
			{
				this.babelTowerLevelId_ = value;
			}
		}

		// Token: 0x170051A2 RID: 20898
		// (get) Token: 0x060183A8 RID: 99240 RVA: 0x00386EDA File Offset: 0x003850DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BabelDeTermId
		{
			get
			{
				return this.babelDeTermId_;
			}
		}

		// Token: 0x060183A9 RID: 99241 RVA: 0x00386EE2 File Offset: 0x003850E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectBabelActivityDeTermRequest);
		}

		// Token: 0x060183AA RID: 99242 RVA: 0x00386EF0 File Offset: 0x003850F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectBabelActivityDeTermRequest other)
		{
			return other != null && (other == this || (this.BabelTowerLevelId == other.BabelTowerLevelId && this.babelDeTermId_.Equals(other.babelDeTermId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060183AB RID: 99243 RVA: 0x00386F40 File Offset: 0x00385140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BabelTowerLevelId != 0)
			{
				num ^= this.BabelTowerLevelId.GetHashCode();
			}
			num ^= this.babelDeTermId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060183AC RID: 99244 RVA: 0x00386F8D File Offset: 0x0038518D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183AD RID: 99245 RVA: 0x00386F9A File Offset: 0x0038519A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183AE RID: 99246 RVA: 0x00386FA4 File Offset: 0x003851A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.babelDeTermId_.WriteTo(ref output, SelectBabelActivityDeTermRequest._repeated_babelDeTermId_codec);
			if (this.BabelTowerLevelId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.BabelTowerLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060183AF RID: 99247 RVA: 0x00386FF4 File Offset: 0x003851F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BabelTowerLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BabelTowerLevelId);
			}
			num += this.babelDeTermId_.CalculateSize(SelectBabelActivityDeTermRequest._repeated_babelDeTermId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060183B0 RID: 99248 RVA: 0x00387048 File Offset: 0x00385248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectBabelActivityDeTermRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BabelTowerLevelId != 0)
			{
				this.BabelTowerLevelId = other.BabelTowerLevelId;
			}
			this.babelDeTermId_.Add(other.babelDeTermId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060183B1 RID: 99249 RVA: 0x00387095 File Offset: 0x00385295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183B2 RID: 99250 RVA: 0x003870A0 File Offset: 0x003852A0
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
				if (num != 40U && num != 42U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BabelTowerLevelId = input.ReadInt32();
					}
				}
				else
				{
					this.babelDeTermId_.AddEntriesFrom(ref input, SelectBabelActivityDeTermRequest._repeated_babelDeTermId_codec);
				}
			}
		}

		// Token: 0x04008FAB RID: 36779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FAC RID: 36780
		public const int BabelTowerLevelIdFieldNumber = 14;

		// Token: 0x04008FAD RID: 36781
		private int babelTowerLevelId_;

		// Token: 0x04008FAE RID: 36782
		public const int BabelDeTermIdFieldNumber = 5;

		// Token: 0x04008FAF RID: 36783
		private static readonly FieldCodec<int> _repeated_babelDeTermId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008FB0 RID: 36784
		private readonly RepeatedField<int> babelDeTermId_ = new RepeatedField<int>();
	}
}
