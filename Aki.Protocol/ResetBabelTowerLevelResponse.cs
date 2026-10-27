using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F23 RID: 3875
	[NetMessage(EMessageId.ResetBabelTowerLevelResponse)]
	public sealed class ResetBabelTowerLevelResponse : IMessage<ResetBabelTowerLevelResponse>, IMessage, IEquatable<ResetBabelTowerLevelResponse>, IDeepCloneable<ResetBabelTowerLevelResponse>, IBufferMessage
	{
		// Token: 0x06014BD0 RID: 84944 RVA: 0x003026B9 File Offset: 0x003008B9
		[NullableContext(1)]
		public static ResetBabelTowerLevelResponse Create()
		{
			return new ResetBabelTowerLevelResponse();
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x06014BD1 RID: 84945 RVA: 0x003026C0 File Offset: 0x003008C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044EE RID: 17646
		// (get) Token: 0x06014BD2 RID: 84946 RVA: 0x003026C3 File Offset: 0x003008C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetBabelTowerLevelResponse.Descriptor;
			}
		}

		// Token: 0x06014BD3 RID: 84947 RVA: 0x003026CA File Offset: 0x003008CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelResponse()
		{
		}

		// Token: 0x06014BD4 RID: 84948 RVA: 0x003026D2 File Offset: 0x003008D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelResponse(ResetBabelTowerLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014BD5 RID: 84949 RVA: 0x003026F7 File Offset: 0x003008F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetBabelTowerLevelResponse Clone()
		{
			return new ResetBabelTowerLevelResponse(this);
		}

		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x06014BD6 RID: 84950 RVA: 0x003026FF File Offset: 0x003008FF
		// (set) Token: 0x06014BD7 RID: 84951 RVA: 0x00302707 File Offset: 0x00300907
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

		// Token: 0x06014BD8 RID: 84952 RVA: 0x00302710 File Offset: 0x00300910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetBabelTowerLevelResponse);
		}

		// Token: 0x06014BD9 RID: 84953 RVA: 0x0030271E File Offset: 0x0030091E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetBabelTowerLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014BDA RID: 84954 RVA: 0x0030274C File Offset: 0x0030094C
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

		// Token: 0x06014BDB RID: 84955 RVA: 0x00302791 File Offset: 0x00300991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014BDC RID: 84956 RVA: 0x0030279E File Offset: 0x0030099E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014BDD RID: 84957 RVA: 0x003027A7 File Offset: 0x003009A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014BDE RID: 84958 RVA: 0x003027DC File Offset: 0x003009DC
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

		// Token: 0x06014BDF RID: 84959 RVA: 0x0030281A File Offset: 0x00300A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetBabelTowerLevelResponse other)
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

		// Token: 0x06014BE0 RID: 84960 RVA: 0x0030284B File Offset: 0x00300A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014BE1 RID: 84961 RVA: 0x00302854 File Offset: 0x00300A54
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D42 RID: 32066
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D43 RID: 32067
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04007D44 RID: 32068
		private ErrorCode errorCode_;
	}
}
