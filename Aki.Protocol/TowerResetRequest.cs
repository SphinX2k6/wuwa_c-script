using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C6 RID: 5062
	[NetMessage(EMessageId.TowerResetRequest)]
	public sealed class TowerResetRequest : IMessage<TowerResetRequest>, IMessage, IEquatable<TowerResetRequest>, IDeepCloneable<TowerResetRequest>, IBufferMessage
	{
		// Token: 0x0601AD9B RID: 109979 RVA: 0x003E485E File Offset: 0x003E2A5E
		[NullableContext(1)]
		public static TowerResetRequest Create()
		{
			return new TowerResetRequest();
		}

		// Token: 0x17005A8E RID: 23182
		// (get) Token: 0x0601AD9C RID: 109980 RVA: 0x003E4865 File Offset: 0x003E2A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A8F RID: 23183
		// (get) Token: 0x0601AD9D RID: 109981 RVA: 0x003E4868 File Offset: 0x003E2A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerResetRequest.Descriptor;
			}
		}

		// Token: 0x0601AD9E RID: 109982 RVA: 0x003E486F File Offset: 0x003E2A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetRequest()
		{
		}

		// Token: 0x0601AD9F RID: 109983 RVA: 0x003E4877 File Offset: 0x003E2A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetRequest(TowerResetRequest other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADA0 RID: 109984 RVA: 0x003E489C File Offset: 0x003E2A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetRequest Clone()
		{
			return new TowerResetRequest(this);
		}

		// Token: 0x17005A90 RID: 23184
		// (get) Token: 0x0601ADA1 RID: 109985 RVA: 0x003E48A4 File Offset: 0x003E2AA4
		// (set) Token: 0x0601ADA2 RID: 109986 RVA: 0x003E48AC File Offset: 0x003E2AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x0601ADA3 RID: 109987 RVA: 0x003E48B5 File Offset: 0x003E2AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerResetRequest);
		}

		// Token: 0x0601ADA4 RID: 109988 RVA: 0x003E48C3 File Offset: 0x003E2AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerResetRequest other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADA5 RID: 109989 RVA: 0x003E48F4 File Offset: 0x003E2AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ADA6 RID: 109990 RVA: 0x003E4933 File Offset: 0x003E2B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADA7 RID: 109991 RVA: 0x003E4940 File Offset: 0x003E2B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADA8 RID: 109992 RVA: 0x003E4949 File Offset: 0x003E2B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADA9 RID: 109993 RVA: 0x003E497C File Offset: 0x003E2B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ADAA RID: 109994 RVA: 0x003E49BA File Offset: 0x003E2BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerResetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ADAB RID: 109995 RVA: 0x003E49EB File Offset: 0x003E2BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADAC RID: 109996 RVA: 0x003E49F4 File Offset: 0x003E2BF4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TowerConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009BCD RID: 39885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BCE RID: 39886
		public const int TowerConfigIdFieldNumber = 11;

		// Token: 0x04009BCF RID: 39887
		private int towerConfigId_;
	}
}
