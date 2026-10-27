using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000078 RID: 120
	[NetMessage(EMessageId.ActionResetPosPrePerformanceEndResponse)]
	public sealed class ActionResetPosPrePerformanceEndResponse : IMessage<ActionResetPosPrePerformanceEndResponse>, IMessage, IEquatable<ActionResetPosPrePerformanceEndResponse>, IDeepCloneable<ActionResetPosPrePerformanceEndResponse>, IBufferMessage
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x0003F400 File Offset: 0x0003D600
		[NullableContext(1)]
		public static ActionResetPosPrePerformanceEndResponse Create()
		{
			return new ActionResetPosPrePerformanceEndResponse();
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0003F407 File Offset: 0x0003D607
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
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0003F40A File Offset: 0x0003D60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionResetPosPrePerformanceEndResponse.Descriptor;
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0003F411 File Offset: 0x0003D611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndResponse()
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0003F419 File Offset: 0x0003D619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndResponse(ActionResetPosPrePerformanceEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0003F43E File Offset: 0x0003D63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndResponse Clone()
		{
			return new ActionResetPosPrePerformanceEndResponse(this);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x0003F446 File Offset: 0x0003D646
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x0003F44E File Offset: 0x0003D64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0003F457 File Offset: 0x0003D657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionResetPosPrePerformanceEndResponse);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0003F465 File Offset: 0x0003D665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionResetPosPrePerformanceEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0003F494 File Offset: 0x0003D694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0003F4D9 File Offset: 0x0003D6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0003F4E6 File Offset: 0x0003D6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0003F4EF File Offset: 0x0003D6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0003F524 File Offset: 0x0003D724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0003F562 File Offset: 0x0003D762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionResetPosPrePerformanceEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0003F593 File Offset: 0x0003D793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0003F59C File Offset: 0x0003D79C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002167 RID: 8551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002168 RID: 8552
		public const int CodeFieldNumber = 2;

		// Token: 0x04002169 RID: 8553
		private ErrorCode code_;
	}
}
