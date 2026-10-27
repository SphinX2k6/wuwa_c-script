using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F22 RID: 3874
	[NetMessage(EMessageId.ResetBabelTowerLevelRequest)]
	public sealed class ResetBabelTowerLevelRequest : IMessage<ResetBabelTowerLevelRequest>, IMessage, IEquatable<ResetBabelTowerLevelRequest>, IDeepCloneable<ResetBabelTowerLevelRequest>, IBufferMessage
	{
		// Token: 0x06014BBE RID: 84926 RVA: 0x003024E0 File Offset: 0x003006E0
		[NullableContext(1)]
		public static ResetBabelTowerLevelRequest Create()
		{
			return new ResetBabelTowerLevelRequest();
		}

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x06014BBF RID: 84927 RVA: 0x003024E7 File Offset: 0x003006E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x06014BC0 RID: 84928 RVA: 0x003024EA File Offset: 0x003006EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetBabelTowerLevelRequest.Descriptor;
			}
		}

		// Token: 0x06014BC1 RID: 84929 RVA: 0x003024F1 File Offset: 0x003006F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelRequest()
		{
		}

		// Token: 0x06014BC2 RID: 84930 RVA: 0x003024F9 File Offset: 0x003006F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelRequest(ResetBabelTowerLevelRequest other) : this()
		{
			this.babelTowerLevelId_ = other.babelTowerLevelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014BC3 RID: 84931 RVA: 0x0030251E File Offset: 0x0030071E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelRequest Clone()
		{
			return new ResetBabelTowerLevelRequest(this);
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x06014BC4 RID: 84932 RVA: 0x00302526 File Offset: 0x00300726
		// (set) Token: 0x06014BC5 RID: 84933 RVA: 0x0030252E File Offset: 0x0030072E
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

		// Token: 0x06014BC6 RID: 84934 RVA: 0x00302537 File Offset: 0x00300737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetBabelTowerLevelRequest);
		}

		// Token: 0x06014BC7 RID: 84935 RVA: 0x00302545 File Offset: 0x00300745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetBabelTowerLevelRequest other)
		{
			return other != null && (other == this || (this.BabelTowerLevelId == other.BabelTowerLevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BC8 RID: 84936 RVA: 0x00302574 File Offset: 0x00300774
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

		// Token: 0x06014BC9 RID: 84937 RVA: 0x003025B3 File Offset: 0x003007B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BCA RID: 84938 RVA: 0x003025C0 File Offset: 0x003007C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BCB RID: 84939 RVA: 0x003025C9 File Offset: 0x003007C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BabelTowerLevelId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BabelTowerLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014BCC RID: 84940 RVA: 0x003025FC File Offset: 0x003007FC
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

		// Token: 0x06014BCD RID: 84941 RVA: 0x0030263A File Offset: 0x0030083A
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

		// Token: 0x06014BCE RID: 84942 RVA: 0x0030266B File Offset: 0x0030086B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BCF RID: 84943 RVA: 0x00302674 File Offset: 0x00300874
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BabelTowerLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D3F RID: 32063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D40 RID: 32064
		public const int BabelTowerLevelIdFieldNumber = 3;

		// Token: 0x04007D41 RID: 32065
		private int babelTowerLevelId_;
	}
}
