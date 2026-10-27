using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DA RID: 4570
	[NetMessage(EMessageId.SetPlayerYuXueModeRequest)]
	public sealed class SetPlayerYuXueModeRequest : IMessage<SetPlayerYuXueModeRequest>, IMessage, IEquatable<SetPlayerYuXueModeRequest>, IDeepCloneable<SetPlayerYuXueModeRequest>, IBufferMessage
	{
		// Token: 0x060185DE RID: 99806 RVA: 0x0038B4A7 File Offset: 0x003896A7
		[NullableContext(1)]
		public static SetPlayerYuXueModeRequest Create()
		{
			return new SetPlayerYuXueModeRequest();
		}

		// Token: 0x1700520A RID: 21002
		// (get) Token: 0x060185DF RID: 99807 RVA: 0x0038B4AE File Offset: 0x003896AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700520B RID: 21003
		// (get) Token: 0x060185E0 RID: 99808 RVA: 0x0038B4B1 File Offset: 0x003896B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetPlayerYuXueModeRequest.Descriptor;
			}
		}

		// Token: 0x060185E1 RID: 99809 RVA: 0x0038B4B8 File Offset: 0x003896B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeRequest()
		{
		}

		// Token: 0x060185E2 RID: 99810 RVA: 0x0038B4C0 File Offset: 0x003896C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeRequest(SetPlayerYuXueModeRequest other) : this()
		{
			this.globalSetting_ = other.globalSetting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185E3 RID: 99811 RVA: 0x0038B4E5 File Offset: 0x003896E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeRequest Clone()
		{
			return new SetPlayerYuXueModeRequest(this);
		}

		// Token: 0x1700520C RID: 21004
		// (get) Token: 0x060185E4 RID: 99812 RVA: 0x0038B4ED File Offset: 0x003896ED
		// (set) Token: 0x060185E5 RID: 99813 RVA: 0x0038B4F5 File Offset: 0x003896F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GlobalSetting
		{
			get
			{
				return this.globalSetting_;
			}
			set
			{
				this.globalSetting_ = value;
			}
		}

		// Token: 0x060185E6 RID: 99814 RVA: 0x0038B4FE File Offset: 0x003896FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetPlayerYuXueModeRequest);
		}

		// Token: 0x060185E7 RID: 99815 RVA: 0x0038B50C File Offset: 0x0038970C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetPlayerYuXueModeRequest other)
		{
			return other != null && (other == this || (this.GlobalSetting == other.GlobalSetting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185E8 RID: 99816 RVA: 0x0038B53C File Offset: 0x0038973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GlobalSetting != 0)
			{
				num ^= this.GlobalSetting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060185E9 RID: 99817 RVA: 0x0038B57B File Offset: 0x0038977B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185EA RID: 99818 RVA: 0x0038B588 File Offset: 0x00389788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185EB RID: 99819 RVA: 0x0038B591 File Offset: 0x00389791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GlobalSetting != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GlobalSetting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185EC RID: 99820 RVA: 0x0038B5C4 File Offset: 0x003897C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GlobalSetting != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GlobalSetting);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060185ED RID: 99821 RVA: 0x0038B602 File Offset: 0x00389802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetPlayerYuXueModeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GlobalSetting != 0)
			{
				this.GlobalSetting = other.GlobalSetting;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060185EE RID: 99822 RVA: 0x0038B633 File Offset: 0x00389833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185EF RID: 99823 RVA: 0x0038B63C File Offset: 0x0038983C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GlobalSetting = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009028 RID: 36904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009029 RID: 36905
		public const int GlobalSettingFieldNumber = 9;

		// Token: 0x0400902A RID: 36906
		private int globalSetting_;
	}
}
