using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156B RID: 5483
	[NetMessage(EMessageId.WeaponRemoveNotify)]
	public sealed class WeaponRemoveNotify : IMessage<WeaponRemoveNotify>, IMessage, IEquatable<WeaponRemoveNotify>, IDeepCloneable<WeaponRemoveNotify>, IBufferMessage
	{
		// Token: 0x0601D09E RID: 118942 RVA: 0x00434D3B File Offset: 0x00432F3B
		[NullableContext(1)]
		public static WeaponRemoveNotify Create()
		{
			return new WeaponRemoveNotify();
		}

		// Token: 0x17006243 RID: 25155
		// (get) Token: 0x0601D09F RID: 118943 RVA: 0x00434D42 File Offset: 0x00432F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006244 RID: 25156
		// (get) Token: 0x0601D0A0 RID: 118944 RVA: 0x00434D45 File Offset: 0x00432F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0601D0A1 RID: 118945 RVA: 0x00434D4C File Offset: 0x00432F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponRemoveNotify()
		{
		}

		// Token: 0x0601D0A2 RID: 118946 RVA: 0x00434D54 File Offset: 0x00432F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponRemoveNotify(WeaponRemoveNotify other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0A3 RID: 118947 RVA: 0x00434D79 File Offset: 0x00432F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponRemoveNotify Clone()
		{
			return new WeaponRemoveNotify(this);
		}

		// Token: 0x17006245 RID: 25157
		// (get) Token: 0x0601D0A4 RID: 118948 RVA: 0x00434D81 File Offset: 0x00432F81
		// (set) Token: 0x0601D0A5 RID: 118949 RVA: 0x00434D89 File Offset: 0x00432F89
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

		// Token: 0x0601D0A6 RID: 118950 RVA: 0x00434D92 File Offset: 0x00432F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponRemoveNotify);
		}

		// Token: 0x0601D0A7 RID: 118951 RVA: 0x00434DA0 File Offset: 0x00432FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponRemoveNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0A8 RID: 118952 RVA: 0x00434DD0 File Offset: 0x00432FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0A9 RID: 118953 RVA: 0x00434E0F File Offset: 0x0043300F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0AA RID: 118954 RVA: 0x00434E1C File Offset: 0x0043301C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0AB RID: 118955 RVA: 0x00434E25 File Offset: 0x00433025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0AC RID: 118956 RVA: 0x00434E58 File Offset: 0x00433058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0AD RID: 118957 RVA: 0x00434E96 File Offset: 0x00433096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0AE RID: 118958 RVA: 0x00434EC7 File Offset: 0x004330C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0AF RID: 118959 RVA: 0x00434ED0 File Offset: 0x004330D0
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A6D8 RID: 42712
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6D9 RID: 42713
		public const int IncIdFieldNumber = 10;

		// Token: 0x0400A6DA RID: 42714
		private int incId_;
	}
}
