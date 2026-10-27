using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146D RID: 5229
	[NetMessage(EMessageId.TriggerExitSkillRequest)]
	public sealed class TriggerExitSkillRequest : IMessage<TriggerExitSkillRequest>, IMessage, IEquatable<TriggerExitSkillRequest>, IDeepCloneable<TriggerExitSkillRequest>, IBufferMessage
	{
		// Token: 0x0601BAF1 RID: 113393 RVA: 0x00401B38 File Offset: 0x003FFD38
		[NullableContext(1)]
		public static TriggerExitSkillRequest Create()
		{
			return new TriggerExitSkillRequest();
		}

		// Token: 0x17005D5C RID: 23900
		// (get) Token: 0x0601BAF2 RID: 113394 RVA: 0x00401B3F File Offset: 0x003FFD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D5D RID: 23901
		// (get) Token: 0x0601BAF3 RID: 113395 RVA: 0x00401B42 File Offset: 0x003FFD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerExitSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601BAF4 RID: 113396 RVA: 0x00401B49 File Offset: 0x003FFD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest()
		{
		}

		// Token: 0x0601BAF5 RID: 113397 RVA: 0x00401B51 File Offset: 0x003FFD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest(TriggerExitSkillRequest other) : this()
		{
			this.enterEntityId_ = other.enterEntityId_;
			this.leaveEntityId_ = other.leaveEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BAF6 RID: 113398 RVA: 0x00401B82 File Offset: 0x003FFD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillRequest Clone()
		{
			return new TriggerExitSkillRequest(this);
		}

		// Token: 0x17005D5E RID: 23902
		// (get) Token: 0x0601BAF7 RID: 113399 RVA: 0x00401B8A File Offset: 0x003FFD8A
		// (set) Token: 0x0601BAF8 RID: 113400 RVA: 0x00401B92 File Offset: 0x003FFD92
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

		// Token: 0x17005D5F RID: 23903
		// (get) Token: 0x0601BAF9 RID: 113401 RVA: 0x00401B9B File Offset: 0x003FFD9B
		// (set) Token: 0x0601BAFA RID: 113402 RVA: 0x00401BA3 File Offset: 0x003FFDA3
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

		// Token: 0x0601BAFB RID: 113403 RVA: 0x00401BAC File Offset: 0x003FFDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerExitSkillRequest);
		}

		// Token: 0x0601BAFC RID: 113404 RVA: 0x00401BBA File Offset: 0x003FFDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerExitSkillRequest other)
		{
			return other != null && (other == this || (this.EnterEntityId == other.EnterEntityId && this.LeaveEntityId == other.LeaveEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BAFD RID: 113405 RVA: 0x00401BF8 File Offset: 0x003FFDF8
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

		// Token: 0x0601BAFE RID: 113406 RVA: 0x00401C50 File Offset: 0x003FFE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BAFF RID: 113407 RVA: 0x00401C5D File Offset: 0x003FFE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB00 RID: 113408 RVA: 0x00401C68 File Offset: 0x003FFE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnterEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EnterEntityId);
			}
			if (this.LeaveEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LeaveEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB01 RID: 113409 RVA: 0x00401CC4 File Offset: 0x003FFEC4
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

		// Token: 0x0601BB02 RID: 113410 RVA: 0x00401D1C File Offset: 0x003FFF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerExitSkillRequest other)
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

		// Token: 0x0601BB03 RID: 113411 RVA: 0x00401D6C File Offset: 0x003FFF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB04 RID: 113412 RVA: 0x00401D78 File Offset: 0x003FFF78
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
				if (num != 40U)
				{
					if (num != 56U)
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

		// Token: 0x04009F81 RID: 40833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F82 RID: 40834
		public const int EnterEntityIdFieldNumber = 5;

		// Token: 0x04009F83 RID: 40835
		private long enterEntityId_;

		// Token: 0x04009F84 RID: 40836
		public const int LeaveEntityIdFieldNumber = 7;

		// Token: 0x04009F85 RID: 40837
		private long leaveEntityId_;
	}
}
