using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156D RID: 5485
	[NetMessage(EMessageId.WeaponResonUpResponse)]
	public sealed class WeaponResonUpResponse : IMessage<WeaponResonUpResponse>, IMessage, IEquatable<WeaponResonUpResponse>, IDeepCloneable<WeaponResonUpResponse>, IBufferMessage
	{
		// Token: 0x0601D0C5 RID: 118981 RVA: 0x00435273 File Offset: 0x00433473
		[NullableContext(1)]
		public static WeaponResonUpResponse Create()
		{
			return new WeaponResonUpResponse();
		}

		// Token: 0x1700624B RID: 25163
		// (get) Token: 0x0601D0C6 RID: 118982 RVA: 0x0043527A File Offset: 0x0043347A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700624C RID: 25164
		// (get) Token: 0x0601D0C7 RID: 118983 RVA: 0x0043527D File Offset: 0x0043347D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponResonUpResponse.Descriptor;
			}
		}

		// Token: 0x0601D0C8 RID: 118984 RVA: 0x00435284 File Offset: 0x00433484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpResponse()
		{
		}

		// Token: 0x0601D0C9 RID: 118985 RVA: 0x0043528C File Offset: 0x0043348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpResponse(WeaponResonUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.incId_ = other.incId_;
			this.reaonLevel_ = other.reaonLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0CA RID: 118986 RVA: 0x004352C9 File Offset: 0x004334C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpResponse Clone()
		{
			return new WeaponResonUpResponse(this);
		}

		// Token: 0x1700624D RID: 25165
		// (get) Token: 0x0601D0CB RID: 118987 RVA: 0x004352D1 File Offset: 0x004334D1
		// (set) Token: 0x0601D0CC RID: 118988 RVA: 0x004352D9 File Offset: 0x004334D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700624E RID: 25166
		// (get) Token: 0x0601D0CD RID: 118989 RVA: 0x004352E2 File Offset: 0x004334E2
		// (set) Token: 0x0601D0CE RID: 118990 RVA: 0x004352EA File Offset: 0x004334EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x1700624F RID: 25167
		// (get) Token: 0x0601D0CF RID: 118991 RVA: 0x004352F3 File Offset: 0x004334F3
		// (set) Token: 0x0601D0D0 RID: 118992 RVA: 0x004352FB File Offset: 0x004334FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReaonLevel
		{
			get
			{
				return this.reaonLevel_;
			}
			set
			{
				this.reaonLevel_ = value;
			}
		}

		// Token: 0x0601D0D1 RID: 118993 RVA: 0x00435304 File Offset: 0x00433504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponResonUpResponse);
		}

		// Token: 0x0601D0D2 RID: 118994 RVA: 0x00435314 File Offset: 0x00433514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponResonUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IncId == other.IncId && this.ReaonLevel == other.ReaonLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0D3 RID: 118995 RVA: 0x00435370 File Offset: 0x00433570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.ReaonLevel != 0)
			{
				num ^= this.ReaonLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0D4 RID: 118996 RVA: 0x004353E7 File Offset: 0x004335E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0D5 RID: 118997 RVA: 0x004353F4 File Offset: 0x004335F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0D6 RID: 118998 RVA: 0x00435400 File Offset: 0x00433600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.IncId);
			}
			if (this.ReaonLevel != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ReaonLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0D7 RID: 118999 RVA: 0x00435478 File Offset: 0x00433678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.ReaonLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReaonLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0D8 RID: 119000 RVA: 0x004354E8 File Offset: 0x004336E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponResonUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.ReaonLevel != 0)
			{
				this.ReaonLevel = other.ReaonLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0D9 RID: 119001 RVA: 0x0043554C File Offset: 0x0043374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0DA RID: 119002 RVA: 0x00435558 File Offset: 0x00433758
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.ReaonLevel = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A6E4 RID: 42724
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6E5 RID: 42725
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A6E6 RID: 42726
		private ErrorCode errorCode_;

		// Token: 0x0400A6E7 RID: 42727
		public const int IncIdFieldNumber = 9;

		// Token: 0x0400A6E8 RID: 42728
		private int incId_;

		// Token: 0x0400A6E9 RID: 42729
		public const int ReaonLevelFieldNumber = 11;

		// Token: 0x0400A6EA RID: 42730
		private int reaonLevel_;
	}
}
