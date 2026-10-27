using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA0 RID: 2976
	[NetMessage(EMessageId.OnlineMotorUpdateNotify)]
	public sealed class OnlineMotorUpdateNotify : IMessage<OnlineMotorUpdateNotify>, IMessage, IEquatable<OnlineMotorUpdateNotify>, IDeepCloneable<OnlineMotorUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010238 RID: 66104 RVA: 0x0025B2D6 File Offset: 0x002594D6
		[NullableContext(1)]
		public static OnlineMotorUpdateNotify Create()
		{
			return new OnlineMotorUpdateNotify();
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x06010239 RID: 66105 RVA: 0x0025B2DD File Offset: 0x002594DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0601023A RID: 66106 RVA: 0x0025B2E0 File Offset: 0x002594E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601023B RID: 66107 RVA: 0x0025B2E7 File Offset: 0x002594E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorUpdateNotify()
		{
		}

		// Token: 0x0601023C RID: 66108 RVA: 0x0025B2F0 File Offset: 0x002594F0
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

		// Token: 0x0601023D RID: 66109 RVA: 0x0025B347 File Offset: 0x00259547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorUpdateNotify Clone()
		{
			return new OnlineMotorUpdateNotify(this);
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0601023E RID: 66110 RVA: 0x0025B34F File Offset: 0x0025954F
		// (set) Token: 0x0601023F RID: 66111 RVA: 0x0025B367 File Offset: 0x00259567
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

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x06010240 RID: 66112 RVA: 0x0025B37D File Offset: 0x0025957D
		// (set) Token: 0x06010241 RID: 66113 RVA: 0x0025B395 File Offset: 0x00259595
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

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x06010242 RID: 66114 RVA: 0x0025B3AB File Offset: 0x002595AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorUpdateNotify.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06010243 RID: 66115 RVA: 0x0025B3B3 File Offset: 0x002595B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = OnlineMotorUpdateNotify.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x06010244 RID: 66116 RVA: 0x0025B3C3 File Offset: 0x002595C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorUpdateNotify);
		}

		// Token: 0x06010245 RID: 66117 RVA: 0x0025B3D4 File Offset: 0x002595D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this.ActivityTasks, other.ActivityTasks) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010246 RID: 66118 RVA: 0x0025B438 File Offset: 0x00259638
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

		// Token: 0x06010247 RID: 66119 RVA: 0x0025B495 File Offset: 0x00259695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010248 RID: 66120 RVA: 0x0025B4A2 File Offset: 0x002596A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010249 RID: 66121 RVA: 0x0025B4AC File Offset: 0x002596AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.ActivityTasks)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ActivityTasks);
			}
			if (this.dataCase_ == OnlineMotorUpdateNotify.DataOneofCase.LevelInfo)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601024A RID: 66122 RVA: 0x0025B508 File Offset: 0x00259708
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

		// Token: 0x0601024B RID: 66123 RVA: 0x0025B560 File Offset: 0x00259760
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

		// Token: 0x0601024C RID: 66124 RVA: 0x0025B5E1 File Offset: 0x002597E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601024D RID: 66125 RVA: 0x0025B5EC File Offset: 0x002597EC
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
				if (num != 26U)
				{
					if (num != 50U)
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

		// Token: 0x040066DD RID: 26333
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066DE RID: 26334
		public const int LevelInfoFieldNumber = 6;

		// Token: 0x040066DF RID: 26335
		public const int ActivityTasksFieldNumber = 3;

		// Token: 0x040066E0 RID: 26336
		private object data_;

		// Token: 0x040066E1 RID: 26337
		private OnlineMotorUpdateNotify.DataOneofCase dataCase_;

		// Token: 0x02001887 RID: 6279
		public enum DataOneofCase
		{
			// Token: 0x0400C877 RID: 51319
			None,
			// Token: 0x0400C878 RID: 51320
			LevelInfo = 6,
			// Token: 0x0400C879 RID: 51321
			ActivityTasks = 3
		}
	}
}
