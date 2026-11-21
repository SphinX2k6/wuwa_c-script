using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A3 RID: 4515
	[NetMessage(EMessageId.SceneItemMoveSplineResponse)]
	public sealed class SceneItemMoveSplineResponse : IMessage<SceneItemMoveSplineResponse>, IMessage, IEquatable<SceneItemMoveSplineResponse>, IDeepCloneable<SceneItemMoveSplineResponse>, IBufferMessage
	{
		// Token: 0x060181DA RID: 98778 RVA: 0x00382F58 File Offset: 0x00381158
		[NullableContext(1)]
		public static SceneItemMoveSplineResponse Create()
		{
			return new SceneItemMoveSplineResponse();
		}

		// Token: 0x17005141 RID: 20801
		// (get) Token: 0x060181DB RID: 98779 RVA: 0x00382F5F File Offset: 0x0038115F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005142 RID: 20802
		// (get) Token: 0x060181DC RID: 98780 RVA: 0x00382F62 File Offset: 0x00381162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveSplineResponse.Descriptor;
			}
		}

		// Token: 0x060181DD RID: 98781 RVA: 0x00382F69 File Offset: 0x00381169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineResponse()
		{
		}

		// Token: 0x060181DE RID: 98782 RVA: 0x00382F71 File Offset: 0x00381171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineResponse(SceneItemMoveSplineResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060181DF RID: 98783 RVA: 0x00382F96 File Offset: 0x00381196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveSplineResponse Clone()
		{
			return new SceneItemMoveSplineResponse(this);
		}

		// Token: 0x17005143 RID: 20803
		// (get) Token: 0x060181E0 RID: 98784 RVA: 0x00382F9E File Offset: 0x0038119E
		// (set) Token: 0x060181E1 RID: 98785 RVA: 0x00382FA6 File Offset: 0x003811A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060181E2 RID: 98786 RVA: 0x00382FAF File Offset: 0x003811AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveSplineResponse);
		}

		// Token: 0x060181E3 RID: 98787 RVA: 0x00382FBD File Offset: 0x003811BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveSplineResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060181E4 RID: 98788 RVA: 0x00382FEC File Offset: 0x003811EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060181E5 RID: 98789 RVA: 0x00383031 File Offset: 0x00381231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060181E6 RID: 98790 RVA: 0x0038303E File Offset: 0x0038123E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060181E7 RID: 98791 RVA: 0x00383047 File Offset: 0x00381247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060181E8 RID: 98792 RVA: 0x0038307C File Offset: 0x0038127C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060181E9 RID: 98793 RVA: 0x003830BA File Offset: 0x003812BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveSplineResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060181EA RID: 98794 RVA: 0x003830EB File Offset: 0x003812EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060181EB RID: 98795 RVA: 0x003830F4 File Offset: 0x003812F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008F97 RID: 36759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F98 RID: 36760
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008F99 RID: 36761
		private ErrorCode errorCode_;
	}
}
