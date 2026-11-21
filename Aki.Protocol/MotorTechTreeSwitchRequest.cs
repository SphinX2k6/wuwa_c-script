using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9E RID: 2718
	[NetMessage(EMessageId.MotorTechTreeSwitchRequest)]
	public sealed class MotorTechTreeSwitchRequest : IMessage<MotorTechTreeSwitchRequest>, IMessage, IEquatable<MotorTechTreeSwitchRequest>, IDeepCloneable<MotorTechTreeSwitchRequest>, IBufferMessage
	{
		// Token: 0x0600ECF5 RID: 60661 RVA: 0x00229D62 File Offset: 0x00227F62
		[NullableContext(1)]
		public static MotorTechTreeSwitchRequest Create()
		{
			return new MotorTechTreeSwitchRequest();
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x0600ECF6 RID: 60662 RVA: 0x00229D69 File Offset: 0x00227F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x0600ECF7 RID: 60663 RVA: 0x00229D6C File Offset: 0x00227F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechTreeSwitchRequest.Descriptor;
			}
		}

		// Token: 0x0600ECF8 RID: 60664 RVA: 0x00229D73 File Offset: 0x00227F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchRequest()
		{
		}

		// Token: 0x0600ECF9 RID: 60665 RVA: 0x00229D7B File Offset: 0x00227F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchRequest(MotorTechTreeSwitchRequest other) : this()
		{
			this.treeId_ = other.treeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECFA RID: 60666 RVA: 0x00229DA0 File Offset: 0x00227FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchRequest Clone()
		{
			return new MotorTechTreeSwitchRequest(this);
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x00229DA8 File Offset: 0x00227FA8
		// (set) Token: 0x0600ECFC RID: 60668 RVA: 0x00229DB0 File Offset: 0x00227FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x0600ECFD RID: 60669 RVA: 0x00229DB9 File Offset: 0x00227FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechTreeSwitchRequest);
		}

		// Token: 0x0600ECFE RID: 60670 RVA: 0x00229DC7 File Offset: 0x00227FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechTreeSwitchRequest other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECFF RID: 60671 RVA: 0x00229DF8 File Offset: 0x00227FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ED00 RID: 60672 RVA: 0x00229E37 File Offset: 0x00228037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED01 RID: 60673 RVA: 0x00229E44 File Offset: 0x00228044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED02 RID: 60674 RVA: 0x00229E4D File Offset: 0x0022804D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED03 RID: 60675 RVA: 0x00229E80 File Offset: 0x00228080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ED04 RID: 60676 RVA: 0x00229EBE File Offset: 0x002280BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechTreeSwitchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ED05 RID: 60677 RVA: 0x00229EEF File Offset: 0x002280EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED06 RID: 60678 RVA: 0x00229EF8 File Offset: 0x002280F8
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
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006065 RID: 24677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006066 RID: 24678
		public const int TreeIdFieldNumber = 11;

		// Token: 0x04006067 RID: 24679
		private int treeId_;
	}
}
