using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000078 RID: 120
	[NetMessage(EMessageId.ActionResetPosPrePerformanceEndRequest)]
	public sealed class ActionResetPosPrePerformanceEndRequest : IMessage<ActionResetPosPrePerformanceEndRequest>, IMessage, IEquatable<ActionResetPosPrePerformanceEndRequest>, IDeepCloneable<ActionResetPosPrePerformanceEndRequest>, IBufferMessage
	{
		// Token: 0x06001844 RID: 6212 RVA: 0x0003F9BA File Offset: 0x0003DBBA
		[NullableContext(1)]
		public static ActionResetPosPrePerformanceEndRequest Create()
		{
			return new ActionResetPosPrePerformanceEndRequest();
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0003F9C1 File Offset: 0x0003DBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0003F9C4 File Offset: 0x0003DBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionResetPosPrePerformanceEndRequest.Descriptor;
			}
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0003F9CB File Offset: 0x0003DBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndRequest()
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0003F9D4 File Offset: 0x0003DBD4
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

		// Token: 0x06001849 RID: 6217 RVA: 0x0003FA28 File Offset: 0x0003DC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndRequest Clone()
		{
			return new ActionResetPosPrePerformanceEndRequest(this);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x0003FA30 File Offset: 0x0003DC30
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x0003FA38 File Offset: 0x0003DC38
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x0003FA41 File Offset: 0x0003DC41
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x0003FA49 File Offset: 0x0003DC49
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x0003FA52 File Offset: 0x0003DC52
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x0003FA5A File Offset: 0x0003DC5A
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0003FA63 File Offset: 0x0003DC63
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x0003FA6B File Offset: 0x0003DC6B
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

		// Token: 0x06001852 RID: 6226 RVA: 0x0003FA74 File Offset: 0x0003DC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionResetPosPrePerformanceEndRequest);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0003FA84 File Offset: 0x0003DC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionResetPosPrePerformanceEndRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.Index == other.Index && this.ContinueExecute == other.ContinueExecute && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0003FAF0 File Offset: 0x0003DCF0
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

		// Token: 0x06001855 RID: 6229 RVA: 0x0003FB7A File Offset: 0x0003DD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0003FB87 File Offset: 0x0003DD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0003FB90 File Offset: 0x0003DD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			if (this.ContinueExecute)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.ContinueExecute);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0003FC20 File Offset: 0x0003DE20
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

		// Token: 0x06001859 RID: 6233 RVA: 0x0003FC9C File Offset: 0x0003DE9C
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

		// Token: 0x0600185A RID: 6234 RVA: 0x0003FD14 File Offset: 0x0003DF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0003FD20 File Offset: 0x0003DF20
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ContinueExecute = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040021BD RID: 8637
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021BE RID: 8638
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040021BF RID: 8639
		private int playerId_;

		// Token: 0x040021C0 RID: 8640
		public const int IncIdFieldNumber = 14;

		// Token: 0x040021C1 RID: 8641
		private int incId_;

		// Token: 0x040021C2 RID: 8642
		public const int IndexFieldNumber = 5;

		// Token: 0x040021C3 RID: 8643
		private int index_;

		// Token: 0x040021C4 RID: 8644
		public const int ContinueExecuteFieldNumber = 8;

		// Token: 0x040021C5 RID: 8645
		private bool continueExecute_;
	}
}
