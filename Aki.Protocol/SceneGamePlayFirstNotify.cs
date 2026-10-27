using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001151 RID: 4433
	[NetMessage(EMessageId.SceneGamePlayFirstNotify)]
	public sealed class SceneGamePlayFirstNotify : IMessage<SceneGamePlayFirstNotify>, IMessage, IEquatable<SceneGamePlayFirstNotify>, IDeepCloneable<SceneGamePlayFirstNotify>, IBufferMessage
	{
		// Token: 0x06017A1B RID: 96795 RVA: 0x0036E3C2 File Offset: 0x0036C5C2
		[NullableContext(1)]
		public static SceneGamePlayFirstNotify Create()
		{
			return new SceneGamePlayFirstNotify();
		}

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x06017A1C RID: 96796 RVA: 0x0036E3C9 File Offset: 0x0036C5C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x06017A1D RID: 96797 RVA: 0x0036E3CC File Offset: 0x0036C5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayFirstNotify.Descriptor;
			}
		}

		// Token: 0x06017A1E RID: 96798 RVA: 0x0036E3D3 File Offset: 0x0036C5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayFirstNotify()
		{
		}

		// Token: 0x06017A1F RID: 96799 RVA: 0x0036E3DB File Offset: 0x0036C5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayFirstNotify(SceneGamePlayFirstNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A20 RID: 96800 RVA: 0x0036E400 File Offset: 0x0036C600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayFirstNotify Clone()
		{
			return new SceneGamePlayFirstNotify(this);
		}

		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x06017A21 RID: 96801 RVA: 0x0036E408 File Offset: 0x0036C608
		// (set) Token: 0x06017A22 RID: 96802 RVA: 0x0036E410 File Offset: 0x0036C610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayId
		{
			get
			{
				return this.gamePlayId_;
			}
			set
			{
				this.gamePlayId_ = value;
			}
		}

		// Token: 0x06017A23 RID: 96803 RVA: 0x0036E419 File Offset: 0x0036C619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayFirstNotify);
		}

		// Token: 0x06017A24 RID: 96804 RVA: 0x0036E427 File Offset: 0x0036C627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayFirstNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A25 RID: 96805 RVA: 0x0036E458 File Offset: 0x0036C658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017A26 RID: 96806 RVA: 0x0036E497 File Offset: 0x0036C697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A27 RID: 96807 RVA: 0x0036E4A4 File Offset: 0x0036C6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A28 RID: 96808 RVA: 0x0036E4AD File Offset: 0x0036C6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A29 RID: 96809 RVA: 0x0036E4E0 File Offset: 0x0036C6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A2A RID: 96810 RVA: 0x0036E51E File Offset: 0x0036C71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayFirstNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A2B RID: 96811 RVA: 0x0036E54F File Offset: 0x0036C74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A2C RID: 96812 RVA: 0x0036E558 File Offset: 0x0036C758
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GamePlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C47 RID: 35911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C48 RID: 35912
		public const int GamePlayIdFieldNumber = 4;

		// Token: 0x04008C49 RID: 35913
		private int gamePlayId_;
	}
}
