using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F2 RID: 5106
	[NetMessage(EMessageId.TimerEndRequest)]
	public sealed class TimerEndRequest : IMessage<TimerEndRequest>, IMessage, IEquatable<TimerEndRequest>, IDeepCloneable<TimerEndRequest>, IBufferMessage
	{
		// Token: 0x0601B274 RID: 111220 RVA: 0x003F38CD File Offset: 0x003F1ACD
		[NullableContext(1)]
		public static TimerEndRequest Create()
		{
			return new TimerEndRequest();
		}

		// Token: 0x17005BEE RID: 23534
		// (get) Token: 0x0601B275 RID: 111221 RVA: 0x003F38D4 File Offset: 0x003F1AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BEF RID: 23535
		// (get) Token: 0x0601B276 RID: 111222 RVA: 0x003F38D7 File Offset: 0x003F1AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimerEndRequest.Descriptor;
			}
		}

		// Token: 0x0601B277 RID: 111223 RVA: 0x003F38DE File Offset: 0x003F1ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndRequest()
		{
		}

		// Token: 0x0601B278 RID: 111224 RVA: 0x003F38F1 File Offset: 0x003F1AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndRequest(TimerEndRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.timerType_ = other.timerType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B279 RID: 111225 RVA: 0x003F392E File Offset: 0x003F1B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerEndRequest Clone()
		{
			return new TimerEndRequest(this);
		}

		// Token: 0x17005BF0 RID: 23536
		// (get) Token: 0x0601B27A RID: 111226 RVA: 0x003F3936 File Offset: 0x003F1B36
		// (set) Token: 0x0601B27B RID: 111227 RVA: 0x003F393E File Offset: 0x003F1B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17005BF1 RID: 23537
		// (get) Token: 0x0601B27C RID: 111228 RVA: 0x003F3947 File Offset: 0x003F1B47
		// (set) Token: 0x0601B27D RID: 111229 RVA: 0x003F394F File Offset: 0x003F1B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17005BF2 RID: 23538
		// (get) Token: 0x0601B27E RID: 111230 RVA: 0x003F3958 File Offset: 0x003F1B58
		// (set) Token: 0x0601B27F RID: 111231 RVA: 0x003F3960 File Offset: 0x003F1B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TimerType
		{
			get
			{
				return this.timerType_;
			}
			set
			{
				this.timerType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601B280 RID: 111232 RVA: 0x003F3973 File Offset: 0x003F1B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimerEndRequest);
		}

		// Token: 0x0601B281 RID: 111233 RVA: 0x003F3984 File Offset: 0x003F1B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimerEndRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.TimerType != other.TimerType) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B282 RID: 111234 RVA: 0x003F39E4 File Offset: 0x003F1BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.TimerType.Length != 0)
			{
				num ^= this.TimerType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B283 RID: 111235 RVA: 0x003F3A57 File Offset: 0x003F1C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B284 RID: 111236 RVA: 0x003F3A64 File Offset: 0x003F1C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B285 RID: 111237 RVA: 0x003F3A70 File Offset: 0x003F1C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TimerType.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.TimerType);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B286 RID: 111238 RVA: 0x003F3AEC File Offset: 0x003F1CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.TimerType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TimerType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B287 RID: 111239 RVA: 0x003F3B60 File Offset: 0x003F1D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimerEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.TimerType.Length != 0)
			{
				this.TimerType = other.TimerType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B288 RID: 111240 RVA: 0x003F3BC9 File Offset: 0x003F1DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B289 RID: 111241 RVA: 0x003F3BD4 File Offset: 0x003F1DD4
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
				if (num != 16U)
				{
					if (num != 82U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeIncId = input.ReadInt64();
						}
					}
					else
					{
						this.TimerType = input.ReadString();
					}
				}
				else
				{
					this.TreeOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E6C RID: 40556
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E6D RID: 40557
		public const int TreeOwnerIdFieldNumber = 2;

		// Token: 0x04009E6E RID: 40558
		private int treeOwnerId_;

		// Token: 0x04009E6F RID: 40559
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x04009E70 RID: 40560
		private long treeIncId_;

		// Token: 0x04009E71 RID: 40561
		public const int TimerTypeFieldNumber = 10;

		// Token: 0x04009E72 RID: 40562
		private string timerType_ = "";
	}
}
