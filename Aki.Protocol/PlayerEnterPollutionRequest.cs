using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D7A RID: 3450
	[NetMessage(EMessageId.PlayerEnterPollutionRequest)]
	public sealed class PlayerEnterPollutionRequest : IMessage<PlayerEnterPollutionRequest>, IMessage, IEquatable<PlayerEnterPollutionRequest>, IDeepCloneable<PlayerEnterPollutionRequest>, IBufferMessage
	{
		// Token: 0x06012A20 RID: 76320 RVA: 0x002B8F97 File Offset: 0x002B7197
		[NullableContext(1)]
		public static PlayerEnterPollutionRequest Create()
		{
			return new PlayerEnterPollutionRequest();
		}

		// Token: 0x17003DD9 RID: 15833
		// (get) Token: 0x06012A21 RID: 76321 RVA: 0x002B8F9E File Offset: 0x002B719E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x06012A22 RID: 76322 RVA: 0x002B8FA1 File Offset: 0x002B71A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerEnterPollutionRequest.Descriptor;
			}
		}

		// Token: 0x06012A23 RID: 76323 RVA: 0x002B8FA8 File Offset: 0x002B71A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionRequest()
		{
		}

		// Token: 0x06012A24 RID: 76324 RVA: 0x002B8FB0 File Offset: 0x002B71B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionRequest(PlayerEnterPollutionRequest other) : this()
		{
			this.managerEntityId_ = other.managerEntityId_;
			this.rangeType_ = other.rangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A25 RID: 76325 RVA: 0x002B8FE1 File Offset: 0x002B71E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerEnterPollutionRequest Clone()
		{
			return new PlayerEnterPollutionRequest(this);
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x06012A26 RID: 76326 RVA: 0x002B8FE9 File Offset: 0x002B71E9
		// (set) Token: 0x06012A27 RID: 76327 RVA: 0x002B8FF1 File Offset: 0x002B71F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ManagerEntityId
		{
			get
			{
				return this.managerEntityId_;
			}
			set
			{
				this.managerEntityId_ = value;
			}
		}

		// Token: 0x17003DDC RID: 15836
		// (get) Token: 0x06012A28 RID: 76328 RVA: 0x002B8FFA File Offset: 0x002B71FA
		// (set) Token: 0x06012A29 RID: 76329 RVA: 0x002B9002 File Offset: 0x002B7202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayEnterOrExitPollutionRangeType RangeType
		{
			get
			{
				return this.rangeType_;
			}
			set
			{
				this.rangeType_ = value;
			}
		}

		// Token: 0x06012A2A RID: 76330 RVA: 0x002B900B File Offset: 0x002B720B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerEnterPollutionRequest);
		}

		// Token: 0x06012A2B RID: 76331 RVA: 0x002B9019 File Offset: 0x002B7219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerEnterPollutionRequest other)
		{
			return other != null && (other == this || (this.ManagerEntityId == other.ManagerEntityId && this.RangeType == other.RangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012A2C RID: 76332 RVA: 0x002B9058 File Offset: 0x002B7258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ManagerEntityId != 0L)
			{
				num ^= this.ManagerEntityId.GetHashCode();
			}
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				num ^= this.RangeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012A2D RID: 76333 RVA: 0x002B90B6 File Offset: 0x002B72B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A2E RID: 76334 RVA: 0x002B90C3 File Offset: 0x002B72C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A2F RID: 76335 RVA: 0x002B90CC File Offset: 0x002B72CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ManagerEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ManagerEntityId);
			}
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.RangeType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A30 RID: 76336 RVA: 0x002B9124 File Offset: 0x002B7324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ManagerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ManagerEntityId);
			}
			if (this.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RangeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012A31 RID: 76337 RVA: 0x002B917C File Offset: 0x002B737C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerEnterPollutionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ManagerEntityId != 0L)
			{
				this.ManagerEntityId = other.ManagerEntityId;
			}
			if (other.RangeType != PlayEnterOrExitPollutionRangeType.EnterAction)
			{
				this.RangeType = other.RangeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A32 RID: 76338 RVA: 0x002B91CC File Offset: 0x002B73CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A33 RID: 76339 RVA: 0x002B91D8 File Offset: 0x002B73D8
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
				if (num != 8U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RangeType = (PlayEnterOrExitPollutionRangeType)input.ReadEnum();
					}
				}
				else
				{
					this.ManagerEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007423 RID: 29731
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007424 RID: 29732
		public const int ManagerEntityIdFieldNumber = 1;

		// Token: 0x04007425 RID: 29733
		private long managerEntityId_;

		// Token: 0x04007426 RID: 29734
		public const int RangeTypeFieldNumber = 13;

		// Token: 0x04007427 RID: 29735
		private PlayEnterOrExitPollutionRangeType rangeType_;
	}
}
