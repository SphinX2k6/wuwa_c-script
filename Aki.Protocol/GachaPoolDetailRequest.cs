using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000682 RID: 1666
	[NetMessage(EMessageId.GachaPoolDetailRequest)]
	public sealed class GachaPoolDetailRequest : IMessage<GachaPoolDetailRequest>, IMessage, IEquatable<GachaPoolDetailRequest>, IDeepCloneable<GachaPoolDetailRequest>, IBufferMessage
	{
		// Token: 0x0600990D RID: 39181 RVA: 0x00171CDE File Offset: 0x0016FEDE
		[NullableContext(1)]
		public static GachaPoolDetailRequest Create()
		{
			return new GachaPoolDetailRequest();
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x0600990E RID: 39182 RVA: 0x00171CE5 File Offset: 0x0016FEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x0600990F RID: 39183 RVA: 0x00171CE8 File Offset: 0x0016FEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaPoolDetailRequest.Descriptor;
			}
		}

		// Token: 0x06009910 RID: 39184 RVA: 0x00171CEF File Offset: 0x0016FEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailRequest()
		{
		}

		// Token: 0x06009911 RID: 39185 RVA: 0x00171CF7 File Offset: 0x0016FEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailRequest(GachaPoolDetailRequest other) : this()
		{
			this.poolId_ = other.poolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00171D1C File Offset: 0x0016FF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaPoolDetailRequest Clone()
		{
			return new GachaPoolDetailRequest(this);
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06009913 RID: 39187 RVA: 0x00171D24 File Offset: 0x0016FF24
		// (set) Token: 0x06009914 RID: 39188 RVA: 0x00171D2C File Offset: 0x0016FF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PoolId
		{
			get
			{
				return this.poolId_;
			}
			set
			{
				this.poolId_ = value;
			}
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x00171D35 File Offset: 0x0016FF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaPoolDetailRequest);
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x00171D43 File Offset: 0x0016FF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaPoolDetailRequest other)
		{
			return other != null && (other == this || (this.PoolId == other.PoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x00171D74 File Offset: 0x0016FF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PoolId != 0)
			{
				num ^= this.PoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x00171DB3 File Offset: 0x0016FFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x00171DC0 File Offset: 0x0016FFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600991A RID: 39194 RVA: 0x00171DC9 File Offset: 0x0016FFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PoolId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600991B RID: 39195 RVA: 0x00171DFC File Offset: 0x0016FFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600991C RID: 39196 RVA: 0x00171E3A File Offset: 0x0017003A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaPoolDetailRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PoolId != 0)
			{
				this.PoolId = other.PoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x00171E6B File Offset: 0x0017006B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x00171E74 File Offset: 0x00170074
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004903 RID: 18691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004904 RID: 18692
		public const int PoolIdFieldNumber = 7;

		// Token: 0x04004905 RID: 18693
		private int poolId_;
	}
}
