using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F12 RID: 3858
	[NetMessage(EMessageId.ResetBabelTowerLevelRequest)]
	public sealed class ResetBabelTowerLevelRequest : IMessage<ResetBabelTowerLevelRequest>, IMessage, IEquatable<ResetBabelTowerLevelRequest>, IDeepCloneable<ResetBabelTowerLevelRequest>, IBufferMessage
	{
		// Token: 0x06014AD9 RID: 84697 RVA: 0x00300E24 File Offset: 0x002FF024
		[NullableContext(1)]
		public static ResetBabelTowerLevelRequest Create()
		{
			return new ResetBabelTowerLevelRequest();
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x06014ADA RID: 84698 RVA: 0x00300E2B File Offset: 0x002FF02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x06014ADB RID: 84699 RVA: 0x00300E2E File Offset: 0x002FF02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetBabelTowerLevelRequest.Descriptor;
			}
		}

		// Token: 0x06014ADC RID: 84700 RVA: 0x00300E35 File Offset: 0x002FF035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelRequest()
		{
		}

		// Token: 0x06014ADD RID: 84701 RVA: 0x00300E3D File Offset: 0x002FF03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelRequest(ResetBabelTowerLevelRequest other) : this()
		{
			this.babelTowerLevelId_ = other.babelTowerLevelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014ADE RID: 84702 RVA: 0x00300E62 File Offset: 0x002FF062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelRequest Clone()
		{
			return new ResetBabelTowerLevelRequest(this);
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x06014ADF RID: 84703 RVA: 0x00300E6A File Offset: 0x002FF06A
		// (set) Token: 0x06014AE0 RID: 84704 RVA: 0x00300E72 File Offset: 0x002FF072
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

		// Token: 0x06014AE1 RID: 84705 RVA: 0x00300E7B File Offset: 0x002FF07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetBabelTowerLevelRequest);
		}

		// Token: 0x06014AE2 RID: 84706 RVA: 0x00300E89 File Offset: 0x002FF089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetBabelTowerLevelRequest other)
		{
			return other != null && (other == this || (this.BabelTowerLevelId == other.BabelTowerLevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AE3 RID: 84707 RVA: 0x00300EB8 File Offset: 0x002FF0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BabelTowerLevelId != 0)
			{
				num ^= this.BabelTowerLevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014AE4 RID: 84708 RVA: 0x00300EF7 File Offset: 0x002FF0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AE5 RID: 84709 RVA: 0x00300F04 File Offset: 0x002FF104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AE6 RID: 84710 RVA: 0x00300F0D File Offset: 0x002FF10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BabelTowerLevelId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.BabelTowerLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014AE7 RID: 84711 RVA: 0x00300F40 File Offset: 0x002FF140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BabelTowerLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BabelTowerLevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014AE8 RID: 84712 RVA: 0x00300F7E File Offset: 0x002FF17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetBabelTowerLevelRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BabelTowerLevelId != 0)
			{
				this.BabelTowerLevelId = other.BabelTowerLevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014AE9 RID: 84713 RVA: 0x00300FAF File Offset: 0x002FF1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AEA RID: 84714 RVA: 0x00300FB8 File Offset: 0x002FF1B8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BabelTowerLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D69 RID: 32105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D6A RID: 32106
		public const int BabelTowerLevelIdFieldNumber = 12;

		// Token: 0x04007D6B RID: 32107
		private int babelTowerLevelId_;
	}
}
