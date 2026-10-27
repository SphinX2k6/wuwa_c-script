using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146C RID: 5228
	[NetMessage(EMessageId.TriggerExitSkillPush)]
	public sealed class TriggerExitSkillPush : IMessage<TriggerExitSkillPush>, IMessage, IEquatable<TriggerExitSkillPush>, IDeepCloneable<TriggerExitSkillPush>, IBufferMessage
	{
		// Token: 0x0601BADD RID: 113373 RVA: 0x0040189E File Offset: 0x003FFA9E
		[NullableContext(1)]
		public static TriggerExitSkillPush Create()
		{
			return new TriggerExitSkillPush();
		}

		// Token: 0x17005D58 RID: 23896
		// (get) Token: 0x0601BADE RID: 113374 RVA: 0x004018A5 File Offset: 0x003FFAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D59 RID: 23897
		// (get) Token: 0x0601BADF RID: 113375 RVA: 0x004018A8 File Offset: 0x003FFAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerExitSkillPush.Descriptor;
			}
		}

		// Token: 0x0601BAE0 RID: 113376 RVA: 0x004018AF File Offset: 0x003FFAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillPush()
		{
		}

		// Token: 0x0601BAE1 RID: 113377 RVA: 0x004018B7 File Offset: 0x003FFAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillPush(TriggerExitSkillPush other) : this()
		{
			this.enterEntityId_ = other.enterEntityId_;
			this.leaveEntityId_ = other.leaveEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAE2 RID: 113378 RVA: 0x004018E8 File Offset: 0x003FFAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillPush Clone()
		{
			return new TriggerExitSkillPush(this);
		}

		// Token: 0x17005D5A RID: 23898
		// (get) Token: 0x0601BAE3 RID: 113379 RVA: 0x004018F0 File Offset: 0x003FFAF0
		// (set) Token: 0x0601BAE4 RID: 113380 RVA: 0x004018F8 File Offset: 0x003FFAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EnterEntityId
		{
			get
			{
				return this.enterEntityId_;
			}
			set
			{
				this.enterEntityId_ = value;
			}
		}

		// Token: 0x17005D5B RID: 23899
		// (get) Token: 0x0601BAE5 RID: 113381 RVA: 0x00401901 File Offset: 0x003FFB01
		// (set) Token: 0x0601BAE6 RID: 113382 RVA: 0x00401909 File Offset: 0x003FFB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LeaveEntityId
		{
			get
			{
				return this.leaveEntityId_;
			}
			set
			{
				this.leaveEntityId_ = value;
			}
		}

		// Token: 0x0601BAE7 RID: 113383 RVA: 0x00401912 File Offset: 0x003FFB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerExitSkillPush);
		}

		// Token: 0x0601BAE8 RID: 113384 RVA: 0x00401920 File Offset: 0x003FFB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerExitSkillPush other)
		{
			return other != null && (other == this || (this.EnterEntityId == other.EnterEntityId && this.LeaveEntityId == other.LeaveEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAE9 RID: 113385 RVA: 0x00401960 File Offset: 0x003FFB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EnterEntityId != 0L)
			{
				num ^= this.EnterEntityId.GetHashCode();
			}
			if (this.LeaveEntityId != 0L)
			{
				num ^= this.LeaveEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BAEA RID: 113386 RVA: 0x004019B8 File Offset: 0x003FFBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAEB RID: 113387 RVA: 0x004019C5 File Offset: 0x003FFBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BAEC RID: 113388 RVA: 0x004019D0 File Offset: 0x003FFBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnterEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EnterEntityId);
			}
			if (this.LeaveEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.LeaveEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BAED RID: 113389 RVA: 0x00401A2C File Offset: 0x003FFC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EnterEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EnterEntityId);
			}
			if (this.LeaveEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LeaveEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BAEE RID: 113390 RVA: 0x00401A84 File Offset: 0x003FFC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerExitSkillPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnterEntityId != 0L)
			{
				this.EnterEntityId = other.EnterEntityId;
			}
			if (other.LeaveEntityId != 0L)
			{
				this.LeaveEntityId = other.LeaveEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BAEF RID: 113391 RVA: 0x00401AD4 File Offset: 0x003FFCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BAF0 RID: 113392 RVA: 0x00401AE0 File Offset: 0x003FFCE0
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
				if (num != 64U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LeaveEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.EnterEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009F7C RID: 40828
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F7D RID: 40829
		public const int EnterEntityIdFieldNumber = 8;

		// Token: 0x04009F7E RID: 40830
		private long enterEntityId_;

		// Token: 0x04009F7F RID: 40831
		public const int LeaveEntityIdFieldNumber = 12;

		// Token: 0x04009F80 RID: 40832
		private long leaveEntityId_;
	}
}
