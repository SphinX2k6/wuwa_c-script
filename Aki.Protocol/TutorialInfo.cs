using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E6 RID: 5350
	public sealed class TutorialInfo : IMessage<TutorialInfo>, IMessage, IEquatable<TutorialInfo>, IDeepCloneable<TutorialInfo>, IBufferMessage
	{
		// Token: 0x0601C5F1 RID: 116209 RVA: 0x0041DD08 File Offset: 0x0041BF08
		[NullableContext(1)]
		public static TutorialInfo Create()
		{
			return new TutorialInfo();
		}

		// Token: 0x17006008 RID: 24584
		// (get) Token: 0x0601C5F2 RID: 116210 RVA: 0x0041DD0F File Offset: 0x0041BF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TutorialInfo> Parser
		{
			get
			{
				return TutorialInfo._parser;
			}
		}

		// Token: 0x17006009 RID: 24585
		// (get) Token: 0x0601C5F3 RID: 116211 RVA: 0x0041DD16 File Offset: 0x0041BF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700600A RID: 24586
		// (get) Token: 0x0601C5F4 RID: 116212 RVA: 0x0041DD19 File Offset: 0x0041BF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialInfo.Descriptor;
			}
		}

		// Token: 0x0601C5F5 RID: 116213 RVA: 0x0041DD20 File Offset: 0x0041BF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfo()
		{
		}

		// Token: 0x0601C5F6 RID: 116214 RVA: 0x0041DD28 File Offset: 0x0041BF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfo(TutorialInfo other) : this()
		{
			this.id_ = other.id_;
			this.createTime_ = other.createTime_;
			this.getAward_ = other.getAward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5F7 RID: 116215 RVA: 0x0041DD65 File Offset: 0x0041BF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialInfo Clone()
		{
			return new TutorialInfo(this);
		}

		// Token: 0x1700600B RID: 24587
		// (get) Token: 0x0601C5F8 RID: 116216 RVA: 0x0041DD6D File Offset: 0x0041BF6D
		// (set) Token: 0x0601C5F9 RID: 116217 RVA: 0x0041DD75 File Offset: 0x0041BF75
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

		// Token: 0x1700600C RID: 24588
		// (get) Token: 0x0601C5FA RID: 116218 RVA: 0x0041DD7E File Offset: 0x0041BF7E
		// (set) Token: 0x0601C5FB RID: 116219 RVA: 0x0041DD86 File Offset: 0x0041BF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x1700600D RID: 24589
		// (get) Token: 0x0601C5FC RID: 116220 RVA: 0x0041DD8F File Offset: 0x0041BF8F
		// (set) Token: 0x0601C5FD RID: 116221 RVA: 0x0041DD97 File Offset: 0x0041BF97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GetAward
		{
			get
			{
				return this.getAward_;
			}
			set
			{
				this.getAward_ = value;
			}
		}

		// Token: 0x0601C5FE RID: 116222 RVA: 0x0041DDA0 File Offset: 0x0041BFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialInfo);
		}

		// Token: 0x0601C5FF RID: 116223 RVA: 0x0041DDB0 File Offset: 0x0041BFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CreateTime == other.CreateTime && this.GetAward == other.GetAward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C600 RID: 116224 RVA: 0x0041DE0C File Offset: 0x0041C00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CreateTime != 0U)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this.GetAward)
			{
				num ^= this.GetAward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C601 RID: 116225 RVA: 0x0041DE7D File Offset: 0x0041C07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C602 RID: 116226 RVA: 0x0041DE8A File Offset: 0x0041C08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C603 RID: 116227 RVA: 0x0041DE94 File Offset: 0x0041C094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CreateTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CreateTime);
			}
			if (this.GetAward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.GetAward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C604 RID: 116228 RVA: 0x0041DF08 File Offset: 0x0041C108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CreateTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CreateTime);
			}
			if (this.GetAward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C605 RID: 116229 RVA: 0x0041DF6C File Offset: 0x0041C16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CreateTime != 0U)
			{
				this.CreateTime = other.CreateTime;
			}
			if (other.GetAward)
			{
				this.GetAward = other.GetAward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C606 RID: 116230 RVA: 0x0041DFD0 File Offset: 0x0041C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C607 RID: 116231 RVA: 0x0041DFDC File Offset: 0x0041C1DC
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GetAward = input.ReadBool();
						}
					}
					else
					{
						this.CreateTime = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A3E6 RID: 41958
		private static readonly MessageParser<TutorialInfo> _parser = new MessageParser<TutorialInfo>(() => new TutorialInfo());

		// Token: 0x0400A3E7 RID: 41959
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3E8 RID: 41960
		public const int IdFieldNumber = 1;

		// Token: 0x0400A3E9 RID: 41961
		private int id_;

		// Token: 0x0400A3EA RID: 41962
		public const int CreateTimeFieldNumber = 2;

		// Token: 0x0400A3EB RID: 41963
		private uint createTime_;

		// Token: 0x0400A3EC RID: 41964
		public const int GetAwardFieldNumber = 3;

		// Token: 0x0400A3ED RID: 41965
		private bool getAward_;
	}
}
