using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA2 RID: 3490
	[NetMessage(EMessageId.PlayerPsnInfoGetRequest)]
	public sealed class PlayerPsnInfoGetRequest : IMessage<PlayerPsnInfoGetRequest>, IMessage, IEquatable<PlayerPsnInfoGetRequest>, IDeepCloneable<PlayerPsnInfoGetRequest>, IBufferMessage
	{
		// Token: 0x06012CE6 RID: 77030 RVA: 0x002BE2E2 File Offset: 0x002BC4E2
		[NullableContext(1)]
		public static PlayerPsnInfoGetRequest Create()
		{
			return new PlayerPsnInfoGetRequest();
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x06012CE7 RID: 77031 RVA: 0x002BE2E9 File Offset: 0x002BC4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x06012CE8 RID: 77032 RVA: 0x002BE2EC File Offset: 0x002BC4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnInfoGetRequest.Descriptor;
			}
		}

		// Token: 0x06012CE9 RID: 77033 RVA: 0x002BE2F3 File Offset: 0x002BC4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetRequest()
		{
		}

		// Token: 0x06012CEA RID: 77034 RVA: 0x002BE306 File Offset: 0x002BC506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetRequest(PlayerPsnInfoGetRequest other) : this()
		{
			this.psnOnlineId_ = other.psnOnlineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CEB RID: 77035 RVA: 0x002BE32B File Offset: 0x002BC52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnInfoGetRequest Clone()
		{
			return new PlayerPsnInfoGetRequest(this);
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x06012CEC RID: 77036 RVA: 0x002BE333 File Offset: 0x002BC533
		// (set) Token: 0x06012CED RID: 77037 RVA: 0x002BE33B File Offset: 0x002BC53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnOnlineId
		{
			get
			{
				return this.psnOnlineId_;
			}
			set
			{
				this.psnOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012CEE RID: 77038 RVA: 0x002BE34E File Offset: 0x002BC54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnInfoGetRequest);
		}

		// Token: 0x06012CEF RID: 77039 RVA: 0x002BE35C File Offset: 0x002BC55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnInfoGetRequest other)
		{
			return other != null && (other == this || (!(this.PsnOnlineId != other.PsnOnlineId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012CF0 RID: 77040 RVA: 0x002BE390 File Offset: 0x002BC590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PsnOnlineId.Length != 0)
			{
				num ^= this.PsnOnlineId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CF1 RID: 77041 RVA: 0x002BE3D1 File Offset: 0x002BC5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CF2 RID: 77042 RVA: 0x002BE3DE File Offset: 0x002BC5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CF3 RID: 77043 RVA: 0x002BE3E7 File Offset: 0x002BC5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PsnOnlineId.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.PsnOnlineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CF4 RID: 77044 RVA: 0x002BE420 File Offset: 0x002BC620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PsnOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnOnlineId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CF5 RID: 77045 RVA: 0x002BE463 File Offset: 0x002BC663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnInfoGetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PsnOnlineId.Length != 0)
			{
				this.PsnOnlineId = other.PsnOnlineId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CF6 RID: 77046 RVA: 0x002BE499 File Offset: 0x002BC699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CF7 RID: 77047 RVA: 0x002BE4A4 File Offset: 0x002BC6A4
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PsnOnlineId = input.ReadString();
				}
			}
		}

		// Token: 0x04007473 RID: 29811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007474 RID: 29812
		public const int PsnOnlineIdFieldNumber = 12;

		// Token: 0x04007475 RID: 29813
		private string psnOnlineId_ = "";
	}
}
