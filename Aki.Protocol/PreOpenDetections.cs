using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC4 RID: 3524
	public sealed class PreOpenDetections : IMessage<PreOpenDetections>, IMessage, IEquatable<PreOpenDetections>, IDeepCloneable<PreOpenDetections>, IBufferMessage
	{
		// Token: 0x06012FF8 RID: 77816 RVA: 0x002C56B8 File Offset: 0x002C38B8
		[NullableContext(1)]
		public static PreOpenDetections Create()
		{
			return new PreOpenDetections();
		}

		// Token: 0x17003F0E RID: 16142
		// (get) Token: 0x06012FF9 RID: 77817 RVA: 0x002C56BF File Offset: 0x002C38BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PreOpenDetections> Parser
		{
			get
			{
				return PreOpenDetections._parser;
			}
		}

		// Token: 0x17003F0F RID: 16143
		// (get) Token: 0x06012FFA RID: 77818 RVA: 0x002C56C6 File Offset: 0x002C38C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x06012FFB RID: 77819 RVA: 0x002C56C9 File Offset: 0x002C38C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreOpenDetections.Descriptor;
			}
		}

		// Token: 0x06012FFC RID: 77820 RVA: 0x002C56D0 File Offset: 0x002C38D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetections()
		{
		}

		// Token: 0x06012FFD RID: 77821 RVA: 0x002C56D8 File Offset: 0x002C38D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetections(PreOpenDetections other) : this()
		{
			this.id_ = other.id_;
			this.preOpenId_ = other.preOpenId_;
			this.preOpenBeginTime_ = other.preOpenBeginTime_;
			this.preOpenEndTime_ = other.preOpenEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FFE RID: 77822 RVA: 0x002C572C File Offset: 0x002C392C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetections Clone()
		{
			return new PreOpenDetections(this);
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x06012FFF RID: 77823 RVA: 0x002C5734 File Offset: 0x002C3934
		// (set) Token: 0x06013000 RID: 77824 RVA: 0x002C573C File Offset: 0x002C393C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x06013001 RID: 77825 RVA: 0x002C5745 File Offset: 0x002C3945
		// (set) Token: 0x06013002 RID: 77826 RVA: 0x002C574D File Offset: 0x002C394D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreOpenId
		{
			get
			{
				return this.preOpenId_;
			}
			set
			{
				this.preOpenId_ = value;
			}
		}

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x06013003 RID: 77827 RVA: 0x002C5756 File Offset: 0x002C3956
		// (set) Token: 0x06013004 RID: 77828 RVA: 0x002C575E File Offset: 0x002C395E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreOpenBeginTime
		{
			get
			{
				return this.preOpenBeginTime_;
			}
			set
			{
				this.preOpenBeginTime_ = value;
			}
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x06013005 RID: 77829 RVA: 0x002C5767 File Offset: 0x002C3967
		// (set) Token: 0x06013006 RID: 77830 RVA: 0x002C576F File Offset: 0x002C396F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreOpenEndTime
		{
			get
			{
				return this.preOpenEndTime_;
			}
			set
			{
				this.preOpenEndTime_ = value;
			}
		}

		// Token: 0x06013007 RID: 77831 RVA: 0x002C5778 File Offset: 0x002C3978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreOpenDetections);
		}

		// Token: 0x06013008 RID: 77832 RVA: 0x002C5788 File Offset: 0x002C3988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreOpenDetections other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PreOpenId == other.PreOpenId && this.PreOpenBeginTime == other.PreOpenBeginTime && this.PreOpenEndTime == other.PreOpenEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013009 RID: 77833 RVA: 0x002C57F4 File Offset: 0x002C39F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PreOpenId != 0)
			{
				num ^= this.PreOpenId.GetHashCode();
			}
			if (this.PreOpenBeginTime != 0L)
			{
				num ^= this.PreOpenBeginTime.GetHashCode();
			}
			if (this.PreOpenEndTime != 0L)
			{
				num ^= this.PreOpenEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601300A RID: 77834 RVA: 0x002C587E File Offset: 0x002C3A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601300B RID: 77835 RVA: 0x002C588B File Offset: 0x002C3A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601300C RID: 77836 RVA: 0x002C5894 File Offset: 0x002C3A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.PreOpenId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PreOpenId);
			}
			if (this.PreOpenBeginTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.PreOpenBeginTime);
			}
			if (this.PreOpenEndTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.PreOpenEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601300D RID: 77837 RVA: 0x002C5924 File Offset: 0x002C3B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.PreOpenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreOpenId);
			}
			if (this.PreOpenBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreOpenBeginTime);
			}
			if (this.PreOpenEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreOpenEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601300E RID: 77838 RVA: 0x002C59AC File Offset: 0x002C3BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreOpenDetections other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.PreOpenId != 0)
			{
				this.PreOpenId = other.PreOpenId;
			}
			if (other.PreOpenBeginTime != 0L)
			{
				this.PreOpenBeginTime = other.PreOpenBeginTime;
			}
			if (other.PreOpenEndTime != 0L)
			{
				this.PreOpenEndTime = other.PreOpenEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601300F RID: 77839 RVA: 0x002C5A24 File Offset: 0x002C3C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013010 RID: 77840 RVA: 0x002C5A30 File Offset: 0x002C3C30
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.PreOpenId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PreOpenBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.PreOpenEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040075BE RID: 30142
		private static readonly MessageParser<PreOpenDetections> _parser = new MessageParser<PreOpenDetections>(() => new PreOpenDetections());

		// Token: 0x040075BF RID: 30143
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075C0 RID: 30144
		public const int IdFieldNumber = 1;

		// Token: 0x040075C1 RID: 30145
		private int id_;

		// Token: 0x040075C2 RID: 30146
		public const int PreOpenIdFieldNumber = 2;

		// Token: 0x040075C3 RID: 30147
		private int preOpenId_;

		// Token: 0x040075C4 RID: 30148
		public const int PreOpenBeginTimeFieldNumber = 3;

		// Token: 0x040075C5 RID: 30149
		private long preOpenBeginTime_;

		// Token: 0x040075C6 RID: 30150
		public const int PreOpenEndTimeFieldNumber = 4;

		// Token: 0x040075C7 RID: 30151
		private long preOpenEndTime_;
	}
}
