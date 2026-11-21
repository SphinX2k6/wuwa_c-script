using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B90 RID: 2960
	[NetMessage(EMessageId.OnlineMotorUpdateNotify)]
	public sealed class OnlineMotorUpdateNotify : IMessage<OnlineMotorUpdateNotify>, IMessage, IEquatable<OnlineMotorUpdateNotify>, IDeepCloneable<OnlineMotorUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010134 RID: 65844 RVA: 0x0025940A File Offset: 0x0025760A
		[NullableContext(1)]
		public static OnlineMotorUpdateNotify Create()
		{
			return new OnlineMotorUpdateNotify();
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x06010135 RID: 65845 RVA: 0x00259411 File Offset: 0x00257611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x06010136 RID: 65846 RVA: 0x00259414 File Offset: 0x00257614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010137 RID: 65847 RVA: 0x0025941B File Offset: 0x0025761B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorUpdateNotify()
		{
		}

		// Token: 0x06010138 RID: 65848 RVA: 0x00259424 File Offset: 0x00257624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorUpdateNotify(OnlineMotorUpdateNotify other) : this()
		{
			OnlineMotorUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
			{
				if (dataCase == OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
				{
					this.LevelInfo = other.LevelInfo.Clone();
				}
			}
			else
			{
				this.ActivityTasks = other.ActivityTasks.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010139 RID: 65849 RVA: 0x0025947C File Offset: 0x0025767C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorUpdateNotify Clone()
		{
			return new OnlineMotorUpdateNotify(this);
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0601013A RID: 65850 RVA: 0x00259484 File Offset: 0x00257684
		// (set) Token: 0x0601013B RID: 65851 RVA: 0x0025949D File Offset: 0x0025769D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorLevelInfo LevelInfo
		{
			get
			{
				if (this.dataCase_ != OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
				{
					return null;
				}
				return (OnlineMotorLevelInfo)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? OnlineMotorUpdateNotify.DataOneofCase.None : OnlineMotorUpdateNotify.DataOneofCase.LevelInfo);
			}
		}

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0601013C RID: 65852 RVA: 0x002594B4 File Offset: 0x002576B4
		// (set) Token: 0x0601013D RID: 65853 RVA: 0x002594CC File Offset: 0x002576CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorTaskUpdate ActivityTasks
		{
			get
			{
				if (this.dataCase_ != OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
				{
					return null;
				}
				return (OnlineMotorTaskUpdate)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? OnlineMotorUpdateNotify.DataOneofCase.None : OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks);
			}
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0601013E RID: 65854 RVA: 0x002594E2 File Offset: 0x002576E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601013F RID: 65855 RVA: 0x002594EA File Offset: 0x002576EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = OnlineMotorUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06010140 RID: 65856 RVA: 0x002594FA File Offset: 0x002576FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorUpdateNotify);
		}

		// Token: 0x06010141 RID: 65857 RVA: 0x00259508 File Offset: 0x00257708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this.ActivityTasks, other.ActivityTasks) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010142 RID: 65858 RVA: 0x0025956C File Offset: 0x0025776C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
			{
				num ^= this.ActivityTasks.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010143 RID: 65859 RVA: 0x002595CA File Offset: 0x002577CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010144 RID: 65860 RVA: 0x002595D7 File Offset: 0x002577D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010145 RID: 65861 RVA: 0x002595E0 File Offset: 0x002577E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ActivityTasks);
			}
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010146 RID: 65862 RVA: 0x0025963C File Offset: 0x0025783C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityTasks);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010147 RID: 65863 RVA: 0x00259698 File Offset: 0x00257898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			OnlineMotorUpdateNotify.DataOneofCase dataCase = other.DataCase;
			if (dataCase != OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
			{
				if (dataCase == OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
				{
					if (this.LevelInfo == null)
					{
						this.LevelInfo = new OnlineMotorLevelInfo();
					}
					this.LevelInfo.MergeFrom(other.LevelInfo);
				}
			}
			else
			{
				if (this.ActivityTasks == null)
				{
					this.ActivityTasks = new OnlineMotorTaskUpdate();
				}
				this.ActivityTasks.MergeFrom(other.ActivityTasks);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010148 RID: 65864 RVA: 0x0025971A File Offset: 0x0025791A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010149 RID: 65865 RVA: 0x00259724 File Offset: 0x00257924
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
				if (num != 66U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						OnlineMotorLevelInfo onlineMotorLevelInfo = new OnlineMotorLevelInfo();
						if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
						{
							onlineMotorLevelInfo.MergeFrom(this.LevelInfo);
						}
						input.ReadMessage(onlineMotorLevelInfo);
						this.LevelInfo = onlineMotorLevelInfo;
					}
				}
				else
				{
					OnlineMotorTaskUpdate onlineMotorTaskUpdate = new OnlineMotorTaskUpdate();
					if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
					{
						onlineMotorTaskUpdate.MergeFrom(this.ActivityTasks);
					}
					input.ReadMessage(onlineMotorTaskUpdate);
					this.ActivityTasks = onlineMotorTaskUpdate;
				}
			}
		}

		// Token: 0x040066ED RID: 26349
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066EE RID: 26350
		public const int LevelInfoFieldNumber = 12;

		// Token: 0x040066EF RID: 26351
		public const int ActivityTasksFieldNumber = 8;

		// Token: 0x040066F0 RID: 26352
		private object data_;

		// Token: 0x040066F1 RID: 26353
		private OnlineMotorUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x020018FF RID: 6399
		public enum DataOneofCase
		{
			// Token: 0x0400CDA2 RID: 52642
			None,
			// Token: 0x0400CDA3 RID: 52643
			LevelInfo = 12,
			// Token: 0x0400CDA4 RID: 52644
			ActivityTasks = 8
		}
	}
}
