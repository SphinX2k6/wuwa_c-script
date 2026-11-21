using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001214 RID: 4628
	[NetMessage(EMessageId.SetPlayerYuXueModeRequest)]
	public sealed class SetPlayerYuXueModeRequest : IMessage<SetPlayerYuXueModeRequest>, IMessage, IEquatable<SetPlayerYuXueModeRequest>, IDeepCloneable<SetPlayerYuXueModeRequest>, IBufferMessage
	{
		// Token: 0x06018B7F RID: 101247 RVA: 0x0039A7D7 File Offset: 0x003989D7
		[NullableContext(1)]
		public static SetPlayerYuXueModeRequest Create()
		{
			return new SetPlayerYuXueModeRequest();
		}

		// Token: 0x17005376 RID: 21366
		// (get) Token: 0x06018B80 RID: 101248 RVA: 0x0039A7DE File Offset: 0x003989DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005377 RID: 21367
		// (get) Token: 0x06018B81 RID: 101249 RVA: 0x0039A7E1 File Offset: 0x003989E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetPlayerYuXueModeRequest.Descriptor;
			}
		}

		// Token: 0x06018B82 RID: 101250 RVA: 0x0039A7E8 File Offset: 0x003989E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeRequest()
		{
		}

		// Token: 0x06018B83 RID: 101251 RVA: 0x0039A7F0 File Offset: 0x003989F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeRequest(SetPlayerYuXueModeRequest other) : this()
		{
			this.globalSetting_ = other.globalSetting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B84 RID: 101252 RVA: 0x0039A815 File Offset: 0x00398A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetPlayerYuXueModeRequest Clone()
		{
			return new SetPlayerYuXueModeRequest(this);
		}

		// Token: 0x17005378 RID: 21368
		// (get) Token: 0x06018B85 RID: 101253 RVA: 0x0039A81D File Offset: 0x00398A1D
		// (set) Token: 0x06018B86 RID: 101254 RVA: 0x0039A825 File Offset: 0x00398A25
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

		// Token: 0x06018B87 RID: 101255 RVA: 0x0039A82E File Offset: 0x00398A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetPlayerYuXueModeRequest);
		}

		// Token: 0x06018B88 RID: 101256 RVA: 0x0039A83C File Offset: 0x00398A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetPlayerYuXueModeRequest other)
		{
			return other != null && (other == this || (this.GlobalSetting == other.GlobalSetting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B89 RID: 101257 RVA: 0x0039A86C File Offset: 0x00398A6C
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

		// Token: 0x06018B8A RID: 101258 RVA: 0x0039A8AB File Offset: 0x00398AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B8B RID: 101259 RVA: 0x0039A8B8 File Offset: 0x00398AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B8C RID: 101260 RVA: 0x0039A8C1 File Offset: 0x00398AC1
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

		// Token: 0x06018B8D RID: 101261 RVA: 0x0039A8F4 File Offset: 0x00398AF4
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

		// Token: 0x06018B8E RID: 101262 RVA: 0x0039A932 File Offset: 0x00398B32
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

		// Token: 0x06018B8F RID: 101263 RVA: 0x0039A963 File Offset: 0x00398B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B90 RID: 101264 RVA: 0x0039A96C File Offset: 0x00398B6C
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

		// Token: 0x040092BB RID: 37563
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092BC RID: 37564
		public const int GlobalSettingFieldNumber = 9;

		// Token: 0x040092BD RID: 37565
		private int globalSetting_;
	}
}
