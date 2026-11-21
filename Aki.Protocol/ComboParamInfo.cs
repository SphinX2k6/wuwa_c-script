using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BD RID: 701
	public sealed class ComboParamInfo : IMessage<ComboParamInfo>, IMessage, IEquatable<ComboParamInfo>, IDeepCloneable<ComboParamInfo>, IBufferMessage
	{
		// Token: 0x06004897 RID: 18583 RVA: 0x000B27A8 File Offset: 0x000B09A8
		[NullableContext(1)]
		public static ComboParamInfo Create()
		{
			return new ComboParamInfo();
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06004898 RID: 18584 RVA: 0x000B27AF File Offset: 0x000B09AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComboParamInfo> Parser
		{
			get
			{
				return ComboParamInfo._parser;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x000B27B6 File Offset: 0x000B09B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600489A RID: 18586 RVA: 0x000B27B9 File Offset: 0x000B09B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComboParamInfo.Descriptor;
			}
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x000B27C0 File Offset: 0x000B09C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComboParamInfo()
		{
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x000B27C8 File Offset: 0x000B09C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComboParamInfo(ComboParamInfo other) : this()
		{
			this.keepTime_ = other.keepTime_;
			this.addTime_ = other.addTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x000B27F9 File Offset: 0x000B09F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComboParamInfo Clone()
		{
			return new ComboParamInfo(this);
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x000B2801 File Offset: 0x000B0A01
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x000B2809 File Offset: 0x000B0A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KeepTime
		{
			get
			{
				return this.keepTime_;
			}
			set
			{
				this.keepTime_ = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x000B2812 File Offset: 0x000B0A12
		// (set) Token: 0x060048A1 RID: 18593 RVA: 0x000B281A File Offset: 0x000B0A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddTime
		{
			get
			{
				return this.addTime_;
			}
			set
			{
				this.addTime_ = value;
			}
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x000B2823 File Offset: 0x000B0A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComboParamInfo);
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x000B2831 File Offset: 0x000B0A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComboParamInfo other)
		{
			return other != null && (other == this || (this.KeepTime == other.KeepTime && this.AddTime == other.AddTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x000B2870 File Offset: 0x000B0A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KeepTime != 0)
			{
				num ^= this.KeepTime.GetHashCode();
			}
			if (this.AddTime != 0)
			{
				num ^= this.AddTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x000B28C8 File Offset: 0x000B0AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x000B28D5 File Offset: 0x000B0AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x000B28E0 File Offset: 0x000B0AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KeepTime != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.KeepTime);
			}
			if (this.AddTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.AddTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x000B2938 File Offset: 0x000B0B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KeepTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KeepTime);
			}
			if (this.AddTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x000B2990 File Offset: 0x000B0B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComboParamInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KeepTime != 0)
			{
				this.KeepTime = other.KeepTime;
			}
			if (other.AddTime != 0)
			{
				this.AddTime = other.AddTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x000B29E0 File Offset: 0x000B0BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x000B29EC File Offset: 0x000B0BEC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AddTime = input.ReadInt32();
					}
				}
				else
				{
					this.KeepTime = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003051 RID: 12369
		private static readonly MessageParser<ComboParamInfo> _parser = new MessageParser<ComboParamInfo>(() => new ComboParamInfo());

		// Token: 0x04003052 RID: 12370
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003053 RID: 12371
		public const int KeepTimeFieldNumber = 1;

		// Token: 0x04003054 RID: 12372
		private int keepTime_;

		// Token: 0x04003055 RID: 12373
		public const int AddTimeFieldNumber = 2;

		// Token: 0x04003056 RID: 12374
		private int addTime_;
	}
}
