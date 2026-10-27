using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000077 RID: 119
	[NetMessage(EMessageId.ActionResetPosPrePerformanceEndRequest)]
	public sealed class ActionResetPosPrePerformanceEndRequest : IMessage<ActionResetPosPrePerformanceEndRequest>, IMessage, IEquatable<ActionResetPosPrePerformanceEndRequest>, IDeepCloneable<ActionResetPosPrePerformanceEndRequest>, IBufferMessage
	{
		// Token: 0x06001801 RID: 6145 RVA: 0x0003F016 File Offset: 0x0003D216
		[NullableContext(1)]
		public static ActionResetPosPrePerformanceEndRequest Create()
		{
			return new ActionResetPosPrePerformanceEndRequest();
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0003F01D File Offset: 0x0003D21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0003F020 File Offset: 0x0003D220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionResetPosPrePerformanceEndRequest.Descriptor;
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0003F027 File Offset: 0x0003D227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndRequest()
		{
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0003F030 File Offset: 0x0003D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndRequest(ActionResetPosPrePerformanceEndRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.index_ = other.index_;
			this.continueExecute_ = other.continueExecute_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0003F084 File Offset: 0x0003D284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndRequest Clone()
		{
			return new ActionResetPosPrePerformanceEndRequest(this);
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x0003F08C File Offset: 0x0003D28C
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x0003F094 File Offset: 0x0003D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x0003F09D File Offset: 0x0003D29D
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x0003F0A5 File Offset: 0x0003D2A5
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0003F0AE File Offset: 0x0003D2AE
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x0003F0B6 File Offset: 0x0003D2B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x0003F0BF File Offset: 0x0003D2BF
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x0003F0C7 File Offset: 0x0003D2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueExecute
		{
			get
			{
				return this.continueExecute_;
			}
			set
			{
				this.continueExecute_ = value;
			}
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0003F0D0 File Offset: 0x0003D2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionResetPosPrePerformanceEndRequest);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0003F0E0 File Offset: 0x0003D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionResetPosPrePerformanceEndRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && this.ContinueExecute == other.ContinueExecute && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0003F14C File Offset: 0x0003D34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.ContinueExecute)
			{
				num ^= this.ContinueExecute.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0003F1D6 File Offset: 0x0003D3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0003F1E3 File Offset: 0x0003D3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0003F1EC File Offset: 0x0003D3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContinueExecute)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ContinueExecute);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0003F27C File Offset: 0x0003D47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.ContinueExecute)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0003F2F8 File Offset: 0x0003D4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionResetPosPrePerformanceEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.ContinueExecute)
			{
				this.ContinueExecute = other.ContinueExecute;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0003F370 File Offset: 0x0003D570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0003F37C File Offset: 0x0003D57C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ContinueExecute = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400215E RID: 8542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400215F RID: 8543
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x04002160 RID: 8544
		private int playerId_;

		// Token: 0x04002161 RID: 8545
		public const int IncIdFieldNumber = 11;

		// Token: 0x04002162 RID: 8546
		private int incId_;

		// Token: 0x04002163 RID: 8547
		public const int IndexFieldNumber = 2;

		// Token: 0x04002164 RID: 8548
		private int index_;

		// Token: 0x04002165 RID: 8549
		public const int ContinueExecuteFieldNumber = 1;

		// Token: 0x04002166 RID: 8550
		private bool continueExecute_;
	}
}
