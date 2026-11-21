using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADB RID: 2779
	[NetMessage(EMessageId.MutiplayerTeamRefreshNearListRequest)]
	public sealed class MutiplayerTeamRefreshNearListRequest : IMessage<MutiplayerTeamRefreshNearListRequest>, IMessage, IEquatable<MutiplayerTeamRefreshNearListRequest>, IDeepCloneable<MutiplayerTeamRefreshNearListRequest>, IBufferMessage
	{
		// Token: 0x0600F20C RID: 61964 RVA: 0x00235CD4 File Offset: 0x00233ED4
		[NullableContext(1)]
		public static MutiplayerTeamRefreshNearListRequest Create()
		{
			return new MutiplayerTeamRefreshNearListRequest();
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0600F20D RID: 61965 RVA: 0x00235CDB File Offset: 0x00233EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x0600F20E RID: 61966 RVA: 0x00235CDE File Offset: 0x00233EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MutiplayerTeamRefreshNearListRequest.Descriptor;
			}
		}

		// Token: 0x0600F20F RID: 61967 RVA: 0x00235CE5 File Offset: 0x00233EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListRequest()
		{
		}

		// Token: 0x0600F210 RID: 61968 RVA: 0x00235CED File Offset: 0x00233EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListRequest(MutiplayerTeamRefreshNearListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F211 RID: 61969 RVA: 0x00235D06 File Offset: 0x00233F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListRequest Clone()
		{
			return new MutiplayerTeamRefreshNearListRequest(this);
		}

		// Token: 0x0600F212 RID: 61970 RVA: 0x00235D0E File Offset: 0x00233F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MutiplayerTeamRefreshNearListRequest);
		}

		// Token: 0x0600F213 RID: 61971 RVA: 0x00235D1C File Offset: 0x00233F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MutiplayerTeamRefreshNearListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F214 RID: 61972 RVA: 0x00235D3C File Offset: 0x00233F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F215 RID: 61973 RVA: 0x00235D62 File Offset: 0x00233F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F216 RID: 61974 RVA: 0x00235D6F File Offset: 0x00233F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F217 RID: 61975 RVA: 0x00235D78 File Offset: 0x00233F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F218 RID: 61976 RVA: 0x00235D90 File Offset: 0x00233F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F219 RID: 61977 RVA: 0x00235DB6 File Offset: 0x00233FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MutiplayerTeamRefreshNearListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F21A RID: 61978 RVA: 0x00235DD3 File Offset: 0x00233FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F21B RID: 61979 RVA: 0x00235DDC File Offset: 0x00233FDC
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006212 RID: 25106
		private UnknownFieldSet _unknownFields;
	}
}
