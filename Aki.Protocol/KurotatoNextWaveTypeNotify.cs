using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000898 RID: 2200
	[NetMessage(EMessageId.KurotatoNextWaveTypeNotify)]
	public sealed class KurotatoNextWaveTypeNotify : IMessage<KurotatoNextWaveTypeNotify>, IMessage, IEquatable<KurotatoNextWaveTypeNotify>, IDeepCloneable<KurotatoNextWaveTypeNotify>, IBufferMessage
	{
		// Token: 0x0600C3CA RID: 50122 RVA: 0x001D07FC File Offset: 0x001CE9FC
		[NullableContext(1)]
		public static KurotatoNextWaveTypeNotify Create()
		{
			return new KurotatoNextWaveTypeNotify();
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x0600C3CB RID: 50123 RVA: 0x001D0803 File Offset: 0x001CEA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x0600C3CC RID: 50124 RVA: 0x001D0806 File Offset: 0x001CEA06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoNextWaveTypeNotify.Descriptor;
			}
		}

		// Token: 0x0600C3CD RID: 50125 RVA: 0x001D080D File Offset: 0x001CEA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveTypeNotify()
		{
		}

		// Token: 0x0600C3CE RID: 50126 RVA: 0x001D0815 File Offset: 0x001CEA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveTypeNotify(KurotatoNextWaveTypeNotify other) : this()
		{
			this.nextWaveType_ = other.nextWaveType_;
			this.nextWaveId_ = other.nextWaveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3CF RID: 50127 RVA: 0x001D0846 File Offset: 0x001CEA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveTypeNotify Clone()
		{
			return new KurotatoNextWaveTypeNotify(this);
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x0600C3D0 RID: 50128 RVA: 0x001D084E File Offset: 0x001CEA4E
		// (set) Token: 0x0600C3D1 RID: 50129 RVA: 0x001D0856 File Offset: 0x001CEA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveType NextWaveType
		{
			get
			{
				return this.nextWaveType_;
			}
			set
			{
				this.nextWaveType_ = value;
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x0600C3D2 RID: 50130 RVA: 0x001D085F File Offset: 0x001CEA5F
		// (set) Token: 0x0600C3D3 RID: 50131 RVA: 0x001D0867 File Offset: 0x001CEA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextWaveId
		{
			get
			{
				return this.nextWaveId_;
			}
			set
			{
				this.nextWaveId_ = value;
			}
		}

		// Token: 0x0600C3D4 RID: 50132 RVA: 0x001D0870 File Offset: 0x001CEA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoNextWaveTypeNotify);
		}

		// Token: 0x0600C3D5 RID: 50133 RVA: 0x001D087E File Offset: 0x001CEA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoNextWaveTypeNotify other)
		{
			return other != null && (other == this || (this.NextWaveType == other.NextWaveType && this.NextWaveId == other.NextWaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3D6 RID: 50134 RVA: 0x001D08BC File Offset: 0x001CEABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num ^= this.NextWaveType.GetHashCode();
			}
			if (this.NextWaveId != 0)
			{
				num ^= this.NextWaveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x001D091A File Offset: 0x001CEB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3D8 RID: 50136 RVA: 0x001D0927 File Offset: 0x001CEB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3D9 RID: 50137 RVA: 0x001D0930 File Offset: 0x001CEB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NextWaveId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NextWaveId);
			}
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.NextWaveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3DA RID: 50138 RVA: 0x001D098C File Offset: 0x001CEB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NextWaveType);
			}
			if (this.NextWaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextWaveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3DB RID: 50139 RVA: 0x001D09E4 File Offset: 0x001CEBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoNextWaveTypeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NextWaveType != KurotatoNextWaveType.Default)
			{
				this.NextWaveType = other.NextWaveType;
			}
			if (other.NextWaveId != 0)
			{
				this.NextWaveId = other.NextWaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3DC RID: 50140 RVA: 0x001D0A34 File Offset: 0x001CEC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x001D0A40 File Offset: 0x001CEC40
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
				if (num != 56U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NextWaveType = (KurotatoNextWaveType)input.ReadEnum();
					}
				}
				else
				{
					this.NextWaveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054DE RID: 21726
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054DF RID: 21727
		public const int NextWaveTypeFieldNumber = 12;

		// Token: 0x040054E0 RID: 21728
		private KurotatoNextWaveType nextWaveType_;

		// Token: 0x040054E1 RID: 21729
		public const int NextWaveIdFieldNumber = 7;

		// Token: 0x040054E2 RID: 21730
		private int nextWaveId_;
	}
}
