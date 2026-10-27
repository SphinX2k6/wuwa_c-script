using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CE RID: 4814
	[NetMessage(EMessageId.SurvivorsLockRequest)]
	public sealed class SurvivorsLockRequest : IMessage<SurvivorsLockRequest>, IMessage, IEquatable<SurvivorsLockRequest>, IDeepCloneable<SurvivorsLockRequest>, IBufferMessage
	{
		// Token: 0x060199D1 RID: 104913 RVA: 0x003B9504 File Offset: 0x003B7704
		[NullableContext(1)]
		public static SurvivorsLockRequest Create()
		{
			return new SurvivorsLockRequest();
		}

		// Token: 0x1700566A RID: 22122
		// (get) Token: 0x060199D2 RID: 104914 RVA: 0x003B950B File Offset: 0x003B770B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700566B RID: 22123
		// (get) Token: 0x060199D3 RID: 104915 RVA: 0x003B950E File Offset: 0x003B770E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLockRequest.Descriptor;
			}
		}

		// Token: 0x060199D4 RID: 104916 RVA: 0x003B9515 File Offset: 0x003B7715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockRequest()
		{
		}

		// Token: 0x060199D5 RID: 104917 RVA: 0x003B951D File Offset: 0x003B771D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockRequest(SurvivorsLockRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.isLock_ = other.isLock_;
			this.clientSelectId_ = other.clientSelectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199D6 RID: 104918 RVA: 0x003B955A File Offset: 0x003B775A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockRequest Clone()
		{
			return new SurvivorsLockRequest(this);
		}

		// Token: 0x1700566C RID: 22124
		// (get) Token: 0x060199D7 RID: 104919 RVA: 0x003B9562 File Offset: 0x003B7762
		// (set) Token: 0x060199D8 RID: 104920 RVA: 0x003B956A File Offset: 0x003B776A
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

		// Token: 0x1700566D RID: 22125
		// (get) Token: 0x060199D9 RID: 104921 RVA: 0x003B9573 File Offset: 0x003B7773
		// (set) Token: 0x060199DA RID: 104922 RVA: 0x003B957B File Offset: 0x003B777B
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

		// Token: 0x1700566E RID: 22126
		// (get) Token: 0x060199DB RID: 104923 RVA: 0x003B9584 File Offset: 0x003B7784
		// (set) Token: 0x060199DC RID: 104924 RVA: 0x003B958C File Offset: 0x003B778C
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

		// Token: 0x060199DD RID: 104925 RVA: 0x003B9595 File Offset: 0x003B7795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLockRequest);
		}

		// Token: 0x060199DE RID: 104926 RVA: 0x003B95A4 File Offset: 0x003B77A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLockRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.IsLock == other.IsLock && this.ClientSelectId == other.ClientSelectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060199DF RID: 104927 RVA: 0x003B9600 File Offset: 0x003B7800
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

		// Token: 0x060199E0 RID: 104928 RVA: 0x003B9671 File Offset: 0x003B7871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199E1 RID: 104929 RVA: 0x003B967E File Offset: 0x003B787E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199E2 RID: 104930 RVA: 0x003B9688 File Offset: 0x003B7888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsLock)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsLock);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IncId);
			}
			if (this.ClientSelectId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ClientSelectId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199E3 RID: 104931 RVA: 0x003B9700 File Offset: 0x003B7900
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

		// Token: 0x060199E4 RID: 104932 RVA: 0x003B9764 File Offset: 0x003B7964
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

		// Token: 0x060199E5 RID: 104933 RVA: 0x003B97C8 File Offset: 0x003B79C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199E6 RID: 104934 RVA: 0x003B97D4 File Offset: 0x003B79D4
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
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ClientSelectId = input.ReadInt32();
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.IsLock = input.ReadBool();
				}
			}
		}

		// Token: 0x0400963E RID: 38462
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400963F RID: 38463
		public const int IncIdFieldNumber = 13;

		// Token: 0x04009640 RID: 38464
		private int incId_;

		// Token: 0x04009641 RID: 38465
		public const int IsLockFieldNumber = 4;

		// Token: 0x04009642 RID: 38466
		private bool isLock_;

		// Token: 0x04009643 RID: 38467
		public const int ClientSelectIdFieldNumber = 15;

		// Token: 0x04009644 RID: 38468
		private int clientSelectId_;
	}
}
