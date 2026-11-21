using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A5 RID: 5285
	public sealed class TrapDefenseMonsterPbData : IMessage<TrapDefenseMonsterPbData>, IMessage, IEquatable<TrapDefenseMonsterPbData>, IDeepCloneable<TrapDefenseMonsterPbData>, IBufferMessage
	{
		// Token: 0x0601C0C6 RID: 114886 RVA: 0x00412857 File Offset: 0x00410A57
		[NullableContext(1)]
		public static TrapDefenseMonsterPbData Create()
		{
			return new TrapDefenseMonsterPbData();
		}

		// Token: 0x17005EEF RID: 24303
		// (get) Token: 0x0601C0C7 RID: 114887 RVA: 0x0041285E File Offset: 0x00410A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EF0 RID: 24304
		// (get) Token: 0x0601C0C8 RID: 114888 RVA: 0x00412861 File Offset: 0x00410A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterPbData.Descriptor;
			}
		}

		// Token: 0x0601C0C9 RID: 114889 RVA: 0x00412868 File Offset: 0x00410A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbData()
		{
		}

		// Token: 0x0601C0CA RID: 114890 RVA: 0x00412870 File Offset: 0x00410A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbData(TrapDefenseMonsterPbData other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0CB RID: 114891 RVA: 0x00412895 File Offset: 0x00410A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbData Clone()
		{
			return new TrapDefenseMonsterPbData(this);
		}

		// Token: 0x17005EF1 RID: 24305
		// (get) Token: 0x0601C0CC RID: 114892 RVA: 0x0041289D File Offset: 0x00410A9D
		// (set) Token: 0x0601C0CD RID: 114893 RVA: 0x004128A5 File Offset: 0x00410AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x0601C0CE RID: 114894 RVA: 0x004128AE File Offset: 0x00410AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterPbData);
		}

		// Token: 0x0601C0CF RID: 114895 RVA: 0x004128BC File Offset: 0x00410ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0D0 RID: 114896 RVA: 0x004128EC File Offset: 0x00410AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0D1 RID: 114897 RVA: 0x0041292B File Offset: 0x00410B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0D2 RID: 114898 RVA: 0x00412938 File Offset: 0x00410B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0D3 RID: 114899 RVA: 0x00412941 File Offset: 0x00410B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0D4 RID: 114900 RVA: 0x00412974 File Offset: 0x00410B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0D5 RID: 114901 RVA: 0x004129B2 File Offset: 0x00410BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseMonsterPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0D6 RID: 114902 RVA: 0x004129E3 File Offset: 0x00410BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0D7 RID: 114903 RVA: 0x004129EC File Offset: 0x00410BEC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A264 RID: 41572
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A265 RID: 41573
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A266 RID: 41574
		private int configId_;
	}
}
