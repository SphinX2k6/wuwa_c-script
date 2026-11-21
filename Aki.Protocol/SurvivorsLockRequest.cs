using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133D RID: 4925
	[NetMessage(EMessageId.SurvivorsLockRequest)]
	public sealed class SurvivorsLockRequest : IMessage<SurvivorsLockRequest>, IMessage, IEquatable<SurvivorsLockRequest>, IDeepCloneable<SurvivorsLockRequest>, IBufferMessage
	{
		// Token: 0x0601A407 RID: 107527 RVA: 0x003D3C34 File Offset: 0x003D1E34
		[NullableContext(1)]
		public static SurvivorsLockRequest Create()
		{
			return new SurvivorsLockRequest();
		}

		// Token: 0x170058EB RID: 22763
		// (get) Token: 0x0601A408 RID: 107528 RVA: 0x003D3C3B File Offset: 0x003D1E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058EC RID: 22764
		// (get) Token: 0x0601A409 RID: 107529 RVA: 0x003D3C3E File Offset: 0x003D1E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLockRequest.Descriptor;
			}
		}

		// Token: 0x0601A40A RID: 107530 RVA: 0x003D3C45 File Offset: 0x003D1E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockRequest()
		{
		}

		// Token: 0x0601A40B RID: 107531 RVA: 0x003D3C4D File Offset: 0x003D1E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockRequest(SurvivorsLockRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.isLock_ = other.isLock_;
			this.clientSelectId_ = other.clientSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A40C RID: 107532 RVA: 0x003D3C8A File Offset: 0x003D1E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockRequest Clone()
		{
			return new SurvivorsLockRequest(this);
		}

		// Token: 0x170058ED RID: 22765
		// (get) Token: 0x0601A40D RID: 107533 RVA: 0x003D3C92 File Offset: 0x003D1E92
		// (set) Token: 0x0601A40E RID: 107534 RVA: 0x003D3C9A File Offset: 0x003D1E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170058EE RID: 22766
		// (get) Token: 0x0601A40F RID: 107535 RVA: 0x003D3CA3 File Offset: 0x003D1EA3
		// (set) Token: 0x0601A410 RID: 107536 RVA: 0x003D3CAB File Offset: 0x003D1EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLock
		{
			get
			{
				return this.isLock_;
			}
			set
			{
				this.isLock_ = value;
			}
		}

		// Token: 0x170058EF RID: 22767
		// (get) Token: 0x0601A411 RID: 107537 RVA: 0x003D3CB4 File Offset: 0x003D1EB4
		// (set) Token: 0x0601A412 RID: 107538 RVA: 0x003D3CBC File Offset: 0x003D1EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClientSelectId
		{
			get
			{
				return this.clientSelectId_;
			}
			set
			{
				this.clientSelectId_ = value;
			}
		}

		// Token: 0x0601A413 RID: 107539 RVA: 0x003D3CC5 File Offset: 0x003D1EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLockRequest);
		}

		// Token: 0x0601A414 RID: 107540 RVA: 0x003D3CD4 File Offset: 0x003D1ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLockRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.IsLock == other.IsLock && this.ClientSelectId == other.ClientSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A415 RID: 107541 RVA: 0x003D3D30 File Offset: 0x003D1F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.IsLock)
			{
				num ^= this.IsLock.GetHashCode();
			}
			if (this.ClientSelectId != 0)
			{
				num ^= this.ClientSelectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A416 RID: 107542 RVA: 0x003D3DA1 File Offset: 0x003D1FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A417 RID: 107543 RVA: 0x003D3DAE File Offset: 0x003D1FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A418 RID: 107544 RVA: 0x003D3DB8 File Offset: 0x003D1FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientSelectId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ClientSelectId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncId);
			}
			if (this.IsLock)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsLock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A419 RID: 107545 RVA: 0x003D3E30 File Offset: 0x003D2030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.IsLock)
			{
				num += 2;
			}
			if (this.ClientSelectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClientSelectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A41A RID: 107546 RVA: 0x003D3E94 File Offset: 0x003D2094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsLockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.IsLock)
			{
				this.IsLock = other.IsLock;
			}
			if (other.ClientSelectId != 0)
			{
				this.ClientSelectId = other.ClientSelectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A41B RID: 107547 RVA: 0x003D3EF8 File Offset: 0x003D20F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A41C RID: 107548 RVA: 0x003D3F04 File Offset: 0x003D2104
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsLock = input.ReadBool();
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.ClientSelectId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A68 RID: 39528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A69 RID: 39529
		public const int IncIdFieldNumber = 5;

		// Token: 0x04009A6A RID: 39530
		private int incId_;

		// Token: 0x04009A6B RID: 39531
		public const int IsLockFieldNumber = 8;

		// Token: 0x04009A6C RID: 39532
		private bool isLock_;

		// Token: 0x04009A6D RID: 39533
		public const int ClientSelectIdFieldNumber = 4;

		// Token: 0x04009A6E RID: 39534
		private int clientSelectId_;
	}
}
