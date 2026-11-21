using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001560 RID: 5472
	[NetMessage(EMessageId.WeaponBreachRequest)]
	public sealed class WeaponBreachRequest : IMessage<WeaponBreachRequest>, IMessage, IEquatable<WeaponBreachRequest>, IDeepCloneable<WeaponBreachRequest>, IBufferMessage
	{
		// Token: 0x0601CFAE RID: 118702 RVA: 0x00432B9D File Offset: 0x00430D9D
		[NullableContext(1)]
		public static WeaponBreachRequest Create()
		{
			return new WeaponBreachRequest();
		}

		// Token: 0x1700620D RID: 25101
		// (get) Token: 0x0601CFAF RID: 118703 RVA: 0x00432BA4 File Offset: 0x00430DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700620E RID: 25102
		// (get) Token: 0x0601CFB0 RID: 118704 RVA: 0x00432BA7 File Offset: 0x00430DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponBreachRequest.Descriptor;
			}
		}

		// Token: 0x0601CFB1 RID: 118705 RVA: 0x00432BAE File Offset: 0x00430DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachRequest()
		{
		}

		// Token: 0x0601CFB2 RID: 118706 RVA: 0x00432BB6 File Offset: 0x00430DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachRequest(WeaponBreachRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFB3 RID: 118707 RVA: 0x00432BDB File Offset: 0x00430DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachRequest Clone()
		{
			return new WeaponBreachRequest(this);
		}

		// Token: 0x1700620F RID: 25103
		// (get) Token: 0x0601CFB4 RID: 118708 RVA: 0x00432BE3 File Offset: 0x00430DE3
		// (set) Token: 0x0601CFB5 RID: 118709 RVA: 0x00432BEB File Offset: 0x00430DEB
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

		// Token: 0x0601CFB6 RID: 118710 RVA: 0x00432BF4 File Offset: 0x00430DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponBreachRequest);
		}

		// Token: 0x0601CFB7 RID: 118711 RVA: 0x00432C02 File Offset: 0x00430E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponBreachRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFB8 RID: 118712 RVA: 0x00432C30 File Offset: 0x00430E30
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

		// Token: 0x0601CFB9 RID: 118713 RVA: 0x00432C6F File Offset: 0x00430E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFBA RID: 118714 RVA: 0x00432C7C File Offset: 0x00430E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFBB RID: 118715 RVA: 0x00432C85 File Offset: 0x00430E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFBC RID: 118716 RVA: 0x00432CB8 File Offset: 0x00430EB8
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

		// Token: 0x0601CFBD RID: 118717 RVA: 0x00432CF6 File Offset: 0x00430EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponBreachRequest other)
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

		// Token: 0x0601CFBE RID: 118718 RVA: 0x00432D27 File Offset: 0x00430F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFBF RID: 118719 RVA: 0x00432D30 File Offset: 0x00430F30
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
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A68B RID: 42635
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A68C RID: 42636
		public const int IncIdFieldNumber = 2;

		// Token: 0x0400A68D RID: 42637
		private int incId_;
	}
}
