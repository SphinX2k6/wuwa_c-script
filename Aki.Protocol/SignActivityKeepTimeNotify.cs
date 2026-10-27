using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001217 RID: 4631
	[NetMessage(EMessageId.SignActivityKeepTimeNotify)]
	public sealed class SignActivityKeepTimeNotify : IMessage<SignActivityKeepTimeNotify>, IMessage, IEquatable<SignActivityKeepTimeNotify>, IDeepCloneable<SignActivityKeepTimeNotify>, IBufferMessage
	{
		// Token: 0x06018ADD RID: 101085 RVA: 0x00396C0D File Offset: 0x00394E0D
		[NullableContext(1)]
		public static SignActivityKeepTimeNotify Create()
		{
			return new SignActivityKeepTimeNotify();
		}

		// Token: 0x17005325 RID: 21285
		// (get) Token: 0x06018ADE RID: 101086 RVA: 0x00396C14 File Offset: 0x00394E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005326 RID: 21286
		// (get) Token: 0x06018ADF RID: 101087 RVA: 0x00396C17 File Offset: 0x00394E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityKeepTimeNotify.Descriptor;
			}
		}

		// Token: 0x06018AE0 RID: 101088 RVA: 0x00396C1E File Offset: 0x00394E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityKeepTimeNotify()
		{
		}

		// Token: 0x06018AE1 RID: 101089 RVA: 0x00396C26 File Offset: 0x00394E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityKeepTimeNotify(SignActivityKeepTimeNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.keepTime_ = other.keepTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018AE2 RID: 101090 RVA: 0x00396C57 File Offset: 0x00394E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityKeepTimeNotify Clone()
		{
			return new SignActivityKeepTimeNotify(this);
		}

		// Token: 0x17005327 RID: 21287
		// (get) Token: 0x06018AE3 RID: 101091 RVA: 0x00396C5F File Offset: 0x00394E5F
		// (set) Token: 0x06018AE4 RID: 101092 RVA: 0x00396C67 File Offset: 0x00394E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17005328 RID: 21288
		// (get) Token: 0x06018AE5 RID: 101093 RVA: 0x00396C70 File Offset: 0x00394E70
		// (set) Token: 0x06018AE6 RID: 101094 RVA: 0x00396C78 File Offset: 0x00394E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KeepTime
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

		// Token: 0x06018AE7 RID: 101095 RVA: 0x00396C81 File Offset: 0x00394E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityKeepTimeNotify);
		}

		// Token: 0x06018AE8 RID: 101096 RVA: 0x00396C8F File Offset: 0x00394E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityKeepTimeNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.KeepTime == other.KeepTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AE9 RID: 101097 RVA: 0x00396CD0 File Offset: 0x00394ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.KeepTime != 0L)
			{
				num ^= this.KeepTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018AEA RID: 101098 RVA: 0x00396D28 File Offset: 0x00394F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AEB RID: 101099 RVA: 0x00396D35 File Offset: 0x00394F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AEC RID: 101100 RVA: 0x00396D40 File Offset: 0x00394F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this.KeepTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.KeepTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018AED RID: 101101 RVA: 0x00396D9C File Offset: 0x00394F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.KeepTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.KeepTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018AEE RID: 101102 RVA: 0x00396DF4 File Offset: 0x00394FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivityKeepTimeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.KeepTime != 0L)
			{
				this.KeepTime = other.KeepTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018AEF RID: 101103 RVA: 0x00396E44 File Offset: 0x00395044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018AF0 RID: 101104 RVA: 0x00396E50 File Offset: 0x00395050
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
				if (num != 104U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KeepTime = input.ReadInt64();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040091BB RID: 37307
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091BC RID: 37308
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040091BD RID: 37309
		private int activityId_;

		// Token: 0x040091BE RID: 37310
		public const int KeepTimeFieldNumber = 14;

		// Token: 0x040091BF RID: 37311
		private long keepTime_;
	}
}
