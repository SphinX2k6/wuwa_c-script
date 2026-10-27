using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014F7 RID: 5367
	[NetMessage(EMessageId.WeaponResonUpResponse)]
	public sealed class WeaponResonUpResponse : IMessage<WeaponResonUpResponse>, IMessage, IEquatable<WeaponResonUpResponse>, IDeepCloneable<WeaponResonUpResponse>, IBufferMessage
	{
		// Token: 0x0601C5FE RID: 116222 RVA: 0x004197B8 File Offset: 0x004179B8
		[NullableContext(1)]
		public static WeaponResonUpResponse Create()
		{
			return new WeaponResonUpResponse();
		}

		// Token: 0x17005FAA RID: 24490
		// (get) Token: 0x0601C5FF RID: 116223 RVA: 0x004197BF File Offset: 0x004179BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FAB RID: 24491
		// (get) Token: 0x0601C600 RID: 116224 RVA: 0x004197C2 File Offset: 0x004179C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponResonUpResponse.Descriptor;
			}
		}

		// Token: 0x0601C601 RID: 116225 RVA: 0x004197C9 File Offset: 0x004179C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpResponse()
		{
		}

		// Token: 0x0601C602 RID: 116226 RVA: 0x004197D1 File Offset: 0x004179D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpResponse(WeaponResonUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.incId_ = other.incId_;
			this.reaonLevel_ = other.reaonLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C603 RID: 116227 RVA: 0x0041980E File Offset: 0x00417A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponResonUpResponse Clone()
		{
			return new WeaponResonUpResponse(this);
		}

		// Token: 0x17005FAC RID: 24492
		// (get) Token: 0x0601C604 RID: 116228 RVA: 0x00419816 File Offset: 0x00417A16
		// (set) Token: 0x0601C605 RID: 116229 RVA: 0x0041981E File Offset: 0x00417A1E
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

		// Token: 0x17005FAD RID: 24493
		// (get) Token: 0x0601C606 RID: 116230 RVA: 0x00419827 File Offset: 0x00417A27
		// (set) Token: 0x0601C607 RID: 116231 RVA: 0x0041982F File Offset: 0x00417A2F
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

		// Token: 0x17005FAE RID: 24494
		// (get) Token: 0x0601C608 RID: 116232 RVA: 0x00419838 File Offset: 0x00417A38
		// (set) Token: 0x0601C609 RID: 116233 RVA: 0x00419840 File Offset: 0x00417A40
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

		// Token: 0x0601C60A RID: 116234 RVA: 0x00419849 File Offset: 0x00417A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponResonUpResponse);
		}

		// Token: 0x0601C60B RID: 116235 RVA: 0x00419858 File Offset: 0x00417A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponResonUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IncId == other.IncId && this.ReaonLevel == other.ReaonLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C60C RID: 116236 RVA: 0x004198B4 File Offset: 0x00417AB4
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

		// Token: 0x0601C60D RID: 116237 RVA: 0x0041992B File Offset: 0x00417B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C60E RID: 116238 RVA: 0x00419938 File Offset: 0x00417B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C60F RID: 116239 RVA: 0x00419944 File Offset: 0x00417B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.IncId);
			}
			if (this.ReaonLevel != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ReaonLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C610 RID: 116240 RVA: 0x004199B8 File Offset: 0x00417BB8
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

		// Token: 0x0601C611 RID: 116241 RVA: 0x00419A28 File Offset: 0x00417C28
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

		// Token: 0x0601C612 RID: 116242 RVA: 0x00419A8C File Offset: 0x00417C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C613 RID: 116243 RVA: 0x00419A98 File Offset: 0x00417C98
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
					if (num != 88U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A28B RID: 41611
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A28C RID: 41612
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A28D RID: 41613
		private ErrorCode errorCode_;

		// Token: 0x0400A28E RID: 41614
		public const int IncIdFieldNumber = 11;

		// Token: 0x0400A28F RID: 41615
		private int incId_;

		// Token: 0x0400A290 RID: 41616
		public const int ReaonLevelFieldNumber = 15;

		// Token: 0x0400A291 RID: 41617
		private int reaonLevel_;
	}
}
